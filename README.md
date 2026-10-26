# Car Rental Desktop App

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-512BD4)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-0078D6)
![EF6](https://img.shields.io/badge/ORM-Entity%20Framework%206-6DB33F)

A Windows desktop application for managing a small car rental business, built with **C#**, **Windows Forms** and **Entity Framework 6** on SQL Server LocalDB. Staff can add cars, search and filter the fleet, rent a car for a date range and see all rentals. Cars become available again automatically once their rental period ends.

The solution follows an **N-tier architecture** with separate entity, data access, business and presentation layers. The user interface is in Turkish.

---

## Features

- **Fleet management**: add cars with model, daily price and availability, with input validation
- **Search and filter** available cars by model name and a minimum/maximum price, updating as you type
- **Rent a car** for a chosen start and end date; the car is marked as unavailable
- **Rental overview**: list of all rentals together with the rented car's model
- **Automatic availability**: a timer checks every 10 seconds and frees up cars whose rental end date has passed
- **Business rules**: start date must be before end date; a car that is already rented can't be rented again

## Architecture

```
┌────────────────────────────────────────────────────────┐
│ Console (WinForms UI)                                  │
│ Form1 · AddCarForm · RentalForm · RentaledCarsForm     │
└───────────────────────────┬────────────────────────────┘
                            ▼
┌────────────────────────────────────────────────────────┐
│ BusinessLayer                                          │
│ ICarManager / CarManager, IRentalManager /             │
│ RentalManager, IListingManager / ListingManager        │
└───────────────────────────┬────────────────────────────┘
                            ▼
┌────────────────────────────────────────────────────────┐
│ DataAccessLayer                                        │
│ ICarDal / CarDal, IRentalDal / RentalDal,              │
│ IListingDal / ListingDal, AppDbContext (EF6),          │
│ Code First migrations                                  │
└───────────────────────────┬────────────────────────────┘
                            ▼
                  SQL Server LocalDB

        EntityLayer (Car, Rental, Listing) is shared by all layers
```

- **Abstract / Concrete split**: each layer exposes interfaces (`Abstract/`) and their implementations (`Concrete/`).
- **Constructor injection**: managers receive their data-access dependency through the constructor, for example `new CarManager(new CarDal())`.
- **Code First**: the database schema is created from the entity classes with EF6 migrations.

### Project structure

```
CarRental.sln
├── EntityLayer/          # Car, Rental, Listing
├── DataAccessLayer/      # AppDbContext, DAL interfaces and classes, Migrations/
├── BusinessLayer/        # Manager interfaces and classes with business rules
└── Console/              # Windows Forms application (startup project)
```

### Data model

| Entity | Fields |
|---|---|
| `Car` | `CarId`, `Model`, `Price`, `isAvailable` |
| `Rental` | `RentalId`, `CarId`, `UserId`, `StartDate`, `EndDate` |
| `Listing` | `Id`, `Title`, `Description`, `Price` |

## Screens

| Form | Purpose |
|---|---|
| `Form1` | Main screen: search by model, name or price range; navigate to adding or renting |
| `AddCarForm` | Add a new car listing |
| `RentalForm` | Pick an available car and a date range, then rent it |
| `RentaledCarsForm` | List of rented cars |

## Getting started

### Prerequisites

- Windows
- Visual Studio 2019 or newer with the **.NET desktop development** workload
- .NET Framework 4.8.1
- SQL Server Express LocalDB (installed with Visual Studio)

### Run

1. Clone the repository and open `CarRental.sln` in Visual Studio.
2. Restore NuGet packages (**right-click the solution → Restore NuGet Packages**).
3. Create the database: open **Tools → NuGet Package Manager → Package Manager Console**, set the default project to **DataAccessLayer**, and run:

   ```powershell
   Update-Database
   ```

4. Set **Console** as the startup project and press **F5**.

The connection string is named `CarRental` in `Console/App.config` and uses `(localdb)\mssqllocaldb` with Windows authentication, so no password is needed.

## Tech stack

C# · .NET Framework 4.8.1 · Windows Forms · Entity Framework 6 (Code First, migrations) · SQL Server LocalDB
