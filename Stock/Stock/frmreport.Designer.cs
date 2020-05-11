namespace Stock
{
    partial class frmreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlışFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Müşteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rapor Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.Adet,
            this.SatışFiyat,
            this.AlışFiyat,
            this.SatışTipi,
            this.Müşteri,
            this.SatışTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(2, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 317);
            this.dataGridView1.TabIndex = 3;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.ReadOnly = true;
            this.Barkod.Width = 125;
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.ReadOnly = true;
            this.Adet.Width = 120;
            // 
            // SatışFiyat
            // 
            this.SatışFiyat.HeaderText = "SatışFiyat";
            this.SatışFiyat.Name = "SatışFiyat";
            this.SatışFiyat.ReadOnly = true;
            this.SatışFiyat.Width = 120;
            // 
            // AlışFiyat
            // 
            this.AlışFiyat.HeaderText = "AlışFiyat";
            this.AlışFiyat.Name = "AlışFiyat";
            this.AlışFiyat.ReadOnly = true;
            this.AlışFiyat.Width = 120;
            // 
            // SatışTipi
            // 
            this.SatışTipi.HeaderText = "SatışTipi";
            this.SatışTipi.Name = "SatışTipi";
            this.SatışTipi.ReadOnly = true;
            this.SatışTipi.Width = 120;
            // 
            // Müşteri
            // 
            this.Müşteri.HeaderText = "Müşteri";
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.ReadOnly = true;
            this.Müşteri.Width = 120;
            // 
            // SatışTarihi
            // 
            this.SatışTarihi.HeaderText = "SatışTarihi";
            this.SatışTarihi.Name = "SatışTarihi";
            this.SatışTarihi.ReadOnly = true;
            this.SatışTarihi.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarih Aralığı";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 29);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Excel\'de Rapor Al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(915, 455);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmreport";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlışFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Müşteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
    }
}