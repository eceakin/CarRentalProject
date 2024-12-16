namespace Console
{
    partial class RentaledCarsForm
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
            this.dgwRentals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRentals
            // 
            this.dgwRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRentals.Location = new System.Drawing.Point(37, 93);
            this.dgwRentals.Name = "dgwRentals";
            this.dgwRentals.RowHeadersWidth = 51;
            this.dgwRentals.RowTemplate.Height = 24;
            this.dgwRentals.Size = new System.Drawing.Size(729, 317);
            this.dgwRentals.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentaledCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwRentals);
            this.Name = "RentaledCarsForm";
            this.Text = "RentaledCarsForm";
            this.Load += new System.EventHandler(this.RentaledCarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRentals;
        private System.Windows.Forms.Button button1;
    }
}