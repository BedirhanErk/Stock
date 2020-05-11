namespace Stock
{
    partial class frmürünekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmürünekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtstokkodu = new System.Windows.Forms.TextBox();
            this.txtstokadı = new System.Windows.Forms.TextBox();
            this.cmboxmiktartipi = new System.Windows.Forms.ComboBox();
            this.txtkatagori = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtalışfiyatı = new System.Windows.Forms.TextBox();
            this.txtsatışfiyatı = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miktar Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Katagori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Satış Fiyatı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(12, 50);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(150, 29);
            this.txtbarkod.TabIndex = 10;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtkatagori_TextChanged);
            this.txtbarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarkod_KeyPress);
            // 
            // txtstokkodu
            // 
            this.txtstokkodu.Location = new System.Drawing.Point(12, 107);
            this.txtstokkodu.Name = "txtstokkodu";
            this.txtstokkodu.Size = new System.Drawing.Size(150, 29);
            this.txtstokkodu.TabIndex = 11;
            // 
            // txtstokadı
            // 
            this.txtstokadı.Location = new System.Drawing.Point(12, 164);
            this.txtstokadı.Name = "txtstokadı";
            this.txtstokadı.Size = new System.Drawing.Size(150, 29);
            this.txtstokadı.TabIndex = 12;
            // 
            // cmboxmiktartipi
            // 
            this.cmboxmiktartipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxmiktartipi.FormattingEnabled = true;
            this.cmboxmiktartipi.Items.AddRange(new object[] {
            "Adet",
            "Kg"});
            this.cmboxmiktartipi.Location = new System.Drawing.Point(12, 221);
            this.cmboxmiktartipi.Name = "cmboxmiktartipi";
            this.cmboxmiktartipi.Size = new System.Drawing.Size(150, 30);
            this.cmboxmiktartipi.TabIndex = 13;
            // 
            // txtkatagori
            // 
            this.txtkatagori.Location = new System.Drawing.Point(250, 50);
            this.txtkatagori.Name = "txtkatagori";
            this.txtkatagori.Size = new System.Drawing.Size(161, 29);
            this.txtkatagori.TabIndex = 14;
            this.txtkatagori.TextChanged += new System.EventHandler(this.txtkatagori_TextChanged);
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(250, 107);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(161, 29);
            this.txtmarka.TabIndex = 15;
            // 
            // txtalışfiyatı
            // 
            this.txtalışfiyatı.Location = new System.Drawing.Point(250, 164);
            this.txtalışfiyatı.Name = "txtalışfiyatı";
            this.txtalışfiyatı.Size = new System.Drawing.Size(161, 29);
            this.txtalışfiyatı.TabIndex = 16;
            // 
            // txtsatışfiyatı
            // 
            this.txtsatışfiyatı.Location = new System.Drawing.Point(250, 221);
            this.txtsatışfiyatı.Name = "txtsatışfiyatı";
            this.txtsatışfiyatı.Size = new System.Drawing.Size(161, 29);
            this.txtsatışfiyatı.TabIndex = 17;
            this.txtsatışfiyatı.Text = "\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Adet";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(127, 288);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(161, 29);
            this.txtadet.TabIndex = 19;
            this.txtadet.Text = "\r\n";
            // 
            // frmürünekle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(453, 457);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsatışfiyatı);
            this.Controls.Add(this.txtalışfiyatı);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtkatagori);
            this.Controls.Add(this.cmboxmiktartipi);
            this.Controls.Add(this.txtstokadı);
            this.Controls.Add(this.txtstokkodu);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmürünekle";
            this.Text = "Ürün Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtstokkodu;
        private System.Windows.Forms.TextBox txtstokadı;
        private System.Windows.Forms.ComboBox cmboxmiktartipi;
        private System.Windows.Forms.TextBox txtkatagori;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtalışfiyatı;
        private System.Windows.Forms.TextBox txtsatışfiyatı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtadet;
    }
}