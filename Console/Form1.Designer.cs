namespace Console
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwFilter = new System.Windows.Forms.DataGridView();
            this.gbxModel = new System.Windows.Forms.GroupBox();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.gbxPrice = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgwRentals = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.gbxModel.SuspendLayout();
            this.gbxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.Location = new System.Drawing.Point(53, 144);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(629, 200);
            this.dgwFilter.TabIndex = 0;
            // 
            // gbxModel
            // 
            this.gbxModel.Controls.Add(this.cbxCar);
            this.gbxModel.Controls.Add(this.lblModel);
            this.gbxModel.Location = new System.Drawing.Point(143, 28);
            this.gbxModel.Name = "gbxModel";
            this.gbxModel.Size = new System.Drawing.Size(230, 81);
            this.gbxModel.TabIndex = 1;
            this.gbxModel.TabStop = false;
            this.gbxModel.Text = "Modele Göre  Ara ";
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(64, 39);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(133, 24);
            this.cbxCar.TabIndex = 1;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(17, 42);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.txtName);
            this.gbxPrice.Controls.Add(this.lblPrice);
            this.gbxPrice.Location = new System.Drawing.Point(379, 28);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Size = new System.Drawing.Size(230, 81);
            this.gbxPrice.TabIndex = 2;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "Araç ismine göre ara";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 16);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "İsim";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(252, 420);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "KİRALA";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(189, 366);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(189, 392);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dgwRentals
            // 
            this.dgwRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRentals.Location = new System.Drawing.Point(772, 161);
            this.dgwRentals.Name = "dgwRentals";
            this.dgwRentals.RowHeadersWidth = 51;
            this.dgwRentals.RowTemplate.Height = 24;
            this.dgwRentals.Size = new System.Drawing.Size(853, 227);
            this.dgwRentals.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1129, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kiralanan Araçlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(629, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyata Göre Ara";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(65, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(88, 22);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uygun İlanlar";
            // 
            // btnAddListing
            // 
            this.btnAddListing.Location = new System.Drawing.Point(505, 445);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(121, 28);
            this.btnAddListing.TabIndex = 10;
            this.btnAddListing.Text = "İLAN EKLE";
            this.btnAddListing.UseVisualStyleBackColor = true;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(466, 368);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(183, 22);
            this.txtAddModel.TabIndex = 11;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(466, 396);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(183, 22);
            this.txtAddPrice.TabIndex = 12;
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.AutoSize = true;
            this.chkIsAvailable.Location = new System.Drawing.Point(515, 424);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(96, 20);
            this.chkIsAvailable.TabIndex = 13;
            this.chkIsAvailable.Text = "Uygun mu?";
            this.chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 566);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.txtAddModel);
            this.Controls.Add(this.btnAddListing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgwRentals);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gbxPrice);
            this.Controls.Add(this.gbxModel);
            this.Controls.Add(this.dgwFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).EndInit();
            this.gbxModel.ResumeLayout(false);
            this.gbxModel.PerformLayout();
            this.gbxPrice.ResumeLayout(false);
            this.gbxPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.GroupBox gbxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox gbxPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgwRentals;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddListing;
        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.CheckBox chkIsAvailable;
        private System.Windows.Forms.Timer Timer;
    }
}

