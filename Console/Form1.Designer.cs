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
            this.lblModel = new System.Windows.Forms.Label();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.gbxPrice = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.gbxModel.SuspendLayout();
            this.gbxPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.Location = new System.Drawing.Point(12, 240);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(757, 150);
            this.dgwFilter.TabIndex = 0;
            // 
            // gbxModel
            // 
            this.gbxModel.Controls.Add(this.cbxModel);
            this.gbxModel.Controls.Add(this.lblModel);
            this.gbxModel.Location = new System.Drawing.Point(23, 28);
            this.gbxModel.Name = "gbxModel";
            this.gbxModel.Size = new System.Drawing.Size(746, 100);
            this.gbxModel.TabIndex = 1;
            this.gbxModel.TabStop = false;
            this.gbxModel.Text = "Modele Göre  Ara ";
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
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(109, 47);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(330, 24);
            this.cbxModel.TabIndex = 1;
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.txtPrice);
            this.gbxPrice.Controls.Add(this.lblPrice);
            this.gbxPrice.Location = new System.Drawing.Point(23, 134);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Size = new System.Drawing.Size(746, 100);
            this.gbxPrice.TabIndex = 2;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "Fiyata Göre Ara";
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
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(330, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.GroupBox gbxModel;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox gbxPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

