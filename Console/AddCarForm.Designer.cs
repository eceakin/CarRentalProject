namespace Console
{
    partial class AddCarForm
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
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.dgwFilter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(428, 274);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(100, 22);
            this.txtAddModel.TabIndex = 0;
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.AutoSize = true;
            this.chkIsAvailable.Location = new System.Drawing.Point(436, 339);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(92, 20);
            this.chkIsAvailable.TabIndex = 2;
            this.chkIsAvailable.Text = "Uygun mu ";
            this.chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(428, 302);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(100, 22);
            this.txtAddPrice.TabIndex = 3;
            // 
            // btnAddListing
            // 
            this.btnAddListing.Location = new System.Drawing.Point(396, 365);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(170, 23);
            this.btnAddListing.TabIndex = 4;
            this.btnAddListing.Text = "İLAN EKLE";
            this.btnAddListing.UseVisualStyleBackColor = true;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // dgwFilter
            // 
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.Location = new System.Drawing.Point(119, 47);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(738, 221);
            this.dgwFilter.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwFilter);
            this.Controls.Add(this.btnAddListing);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.txtAddModel);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.CheckBox chkIsAvailable;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Button btnAddListing;
        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.Button button1;
    }
}