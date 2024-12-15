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
            this.dgwFilter = new System.Windows.Forms.DataGridView();
            this.gbxModel = new System.Windows.Forms.GroupBox();
            this.cbxRental = new System.Windows.Forms.ComboBox();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.gbxPrice = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgwRentals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.gbxModel.SuspendLayout();
            this.gbxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.Location = new System.Drawing.Point(12, 263);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(458, 270);
            this.dgwFilter.TabIndex = 0;
            // 
            // gbxModel
            // 
            this.gbxModel.Controls.Add(this.cbxRental);
            this.gbxModel.Controls.Add(this.cbxCar);
            this.gbxModel.Controls.Add(this.lblModel);
            this.gbxModel.Location = new System.Drawing.Point(23, 28);
            this.gbxModel.Name = "gbxModel";
            this.gbxModel.Size = new System.Drawing.Size(499, 100);
            this.gbxModel.TabIndex = 1;
            this.gbxModel.TabStop = false;
            this.gbxModel.Text = "Modele Göre  Ara ";
            // 
            // cbxRental
            // 
            this.cbxRental.FormattingEnabled = true;
            this.cbxRental.Location = new System.Drawing.Point(314, 47);
            this.cbxRental.Name = "cbxRental";
            this.cbxRental.Size = new System.Drawing.Size(133, 24);
            this.cbxRental.TabIndex = 2;
            this.cbxRental.SelectedIndexChanged += new System.EventHandler(this.cbxRental_SelectedIndexChanged);
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(121, 47);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(133, 24);
            this.cbxCar.TabIndex = 1;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(17, 47);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.txtPrice);
            this.gbxPrice.Controls.Add(this.lblPrice);
            this.gbxPrice.Location = new System.Drawing.Point(23, 134);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Size = new System.Drawing.Size(97, 100);
            this.gbxPrice.TabIndex = 2;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "Fiyata Göre Ara";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 16);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Fiyat";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(447, 220);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "KİRALA";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(431, 134);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(431, 181);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dgwRentals
            // 
            this.dgwRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRentals.Location = new System.Drawing.Point(498, 263);
            this.dgwRentals.Name = "dgwRentals";
            this.dgwRentals.RowHeadersWidth = 51;
            this.dgwRentals.RowTemplate.Height = 24;
            this.dgwRentals.Size = new System.Drawing.Size(498, 270);
            this.dgwRentals.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uygun Araçlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kiralanan Araçlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.GroupBox gbxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox gbxPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgwRentals;
        private System.Windows.Forms.ComboBox cbxRental;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

