namespace Stock
{
    partial class frmreport2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport2));
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlışFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Excel\'de Rapor Al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barkod";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.Adet,
            this.SatışFiyat,
            this.AlışFiyat,
            this.StokAdı,
            this.Kategori,
            this.Marka});
            this.dataGridView1.Location = new System.Drawing.Point(10, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(895, 340);
            this.dataGridView1.TabIndex = 10;
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
            // StokAdı
            // 
            this.StokAdı.HeaderText = "StokAdı";
            this.StokAdı.Name = "StokAdı";
            this.StokAdı.ReadOnly = true;
            this.StokAdı.Width = 120;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            this.Kategori.Width = 120;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            this.Marka.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rapor Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 29);
            this.textBox1.TabIndex = 15;
            // 
            // frmreport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(915, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmreport2";
            this.Text = "Stok Rapor";
            this.Load += new System.EventHandler(this.frmreport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlışFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.TextBox textBox1;
    }
}