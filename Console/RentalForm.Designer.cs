namespace Console
{
    partial class RentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwFilter = new System.Windows.Forms.DataGridView();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.dgwRentals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.Location = new System.Drawing.Point(75, 54);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(562, 236);
            this.dgwFilter.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(254, 309);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(254, 337);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(318, 365);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dgwRentals
            // 
            this.dgwRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRentals.Location = new System.Drawing.Point(662, 54);
            this.dgwRentals.Name = "dgwRentals";
            this.dgwRentals.RowHeadersWidth = 51;
            this.dgwRentals.RowTemplate.Height = 24;
            this.dgwRentals.Size = new System.Drawing.Size(542, 236);
            this.dgwRentals.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwRentals);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgwFilter);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dgwRentals;
        private System.Windows.Forms.Button button1;
    }
}