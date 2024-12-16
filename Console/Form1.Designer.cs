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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.goToAddCarFormBtn = new System.Windows.Forms.Button();
            this.goToRentalFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilter)).BeginInit();
            this.gbxModel.SuspendLayout();
            this.gbxPrice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFilter
            // 
            this.dgwFilter.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilter.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgwFilter.Location = new System.Drawing.Point(401, 209);
            this.dgwFilter.Name = "dgwFilter";
            this.dgwFilter.RowHeadersWidth = 51;
            this.dgwFilter.RowTemplate.Height = 24;
            this.dgwFilter.Size = new System.Drawing.Size(522, 227);
            this.dgwFilter.TabIndex = 0;
            // 
            // gbxModel
            // 
            this.gbxModel.Controls.Add(this.cbxCar);
            this.gbxModel.Controls.Add(this.lblModel);
            this.gbxModel.Location = new System.Drawing.Point(24, 56);
            this.gbxModel.Name = "gbxModel";
            this.gbxModel.Size = new System.Drawing.Size(346, 83);
            this.gbxModel.TabIndex = 1;
            this.gbxModel.TabStop = false;
            this.gbxModel.Text = "Modele Göre  Ara ";
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(68, 28);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(133, 24);
            this.cbxCar.TabIndex = 1;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 31);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.txtName);
            this.gbxPrice.Controls.Add(this.lblPrice);
            this.gbxPrice.Location = new System.Drawing.Point(410, 56);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Size = new System.Drawing.Size(417, 83);
            this.gbxPrice.TabIndex = 2;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "İlan ismine göre ara";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(21, 31);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 16);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "İsim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaxPrice);
            this.groupBox1.Controls.Add(this.txtMinPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(833, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyata Göre Ara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Min Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Fiyat";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaxPrice.Location = new System.Drawing.Point(267, 44);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(160, 22);
            this.txtMaxPrice.TabIndex = 2;
            this.txtMaxPrice.TextChanged += new System.EventHandler(this.txtMaxPrice_TextChanged);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinPrice.Location = new System.Drawing.Point(104, 44);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(157, 22);
            this.txtMinPrice.TabIndex = 1;
            this.txtMinPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(595, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uygun İlanlar";
            // 
            // goToAddCarFormBtn
            // 
            this.goToAddCarFormBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goToAddCarFormBtn.Location = new System.Drawing.Point(45, 460);
            this.goToAddCarFormBtn.Name = "goToAddCarFormBtn";
            this.goToAddCarFormBtn.Size = new System.Drawing.Size(629, 50);
            this.goToAddCarFormBtn.TabIndex = 10;
            this.goToAddCarFormBtn.Text = "İlan Eklemek İçin Tıklayınız";
            this.goToAddCarFormBtn.UseVisualStyleBackColor = true;
            this.goToAddCarFormBtn.Click += new System.EventHandler(this.goToAddCarFormBtn_Click);
            // 
            // goToRentalFormBtn
            // 
            this.goToRentalFormBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goToRentalFormBtn.Location = new System.Drawing.Point(680, 460);
            this.goToRentalFormBtn.Name = "goToRentalFormBtn";
            this.goToRentalFormBtn.Size = new System.Drawing.Size(616, 50);
            this.goToRentalFormBtn.TabIndex = 11;
            this.goToRentalFormBtn.Text = "Araba Kiralamak İçin Tıklayınız";
            this.goToRentalFormBtn.UseVisualStyleBackColor = true;
            this.goToRentalFormBtn.Click += new System.EventHandler(this.goToRentalFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(575, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ana Sayfa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goToRentalFormBtn);
            this.Controls.Add(this.goToAddCarFormBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button goToAddCarFormBtn;
        private System.Windows.Forms.Button goToRentalFormBtn;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

