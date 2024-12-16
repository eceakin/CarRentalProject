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
            this.button1 = new System.Windows.Forms.Button();
            this.goToRentaledForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgwFilter.Location = new System.Drawing.Point(169, 77);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(480, 215);
            this.dgwFilter.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStartDate.Location = new System.Drawing.Point(368, 298);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(224, 25);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEndDate.Location = new System.Drawing.Point(368, 326);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(224, 25);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRent.Location = new System.Drawing.Point(169, 367);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(480, 52);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Aracı Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
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
            // goToRentaledForm
            // 
            this.goToRentaledForm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goToRentaledForm.Location = new System.Drawing.Point(169, 425);
            this.goToRentaledForm.Name = "goToRentaledForm";
            this.goToRentaledForm.Size = new System.Drawing.Size(480, 52);
            this.goToRentaledForm.TabIndex = 6;
            this.goToRentaledForm.Text = "Kiralanan Araçları Görmek İçin Tıklayınız";
            this.goToRentaledForm.UseVisualStyleBackColor = true;
            this.goToRentaledForm.Click += new System.EventHandler(this.goToRentaledForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Araç Kiralama Sayfası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goToRentaledForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgwFilter);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goToRentaledForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}