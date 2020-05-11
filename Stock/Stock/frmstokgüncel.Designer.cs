namespace Stock
{
    partial class frmstokgüncel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstokgüncel));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stokkodutxt = new System.Windows.Forms.TextBox();
            this.stokadtxt = new System.Windows.Forms.TextBox();
            this.katagoritxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.alıştxt = new System.Windows.Forms.TextBox();
            this.satıştxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miktar Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Katagori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Satış Fiyatı";
            // 
            // stokkodutxt
            // 
            this.stokkodutxt.Location = new System.Drawing.Point(12, 52);
            this.stokkodutxt.Name = "stokkodutxt";
            this.stokkodutxt.Size = new System.Drawing.Size(136, 29);
            this.stokkodutxt.TabIndex = 9;
            this.stokkodutxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stokadtxt
            // 
            this.stokadtxt.Location = new System.Drawing.Point(12, 109);
            this.stokadtxt.Name = "stokadtxt";
            this.stokadtxt.Size = new System.Drawing.Size(136, 29);
            this.stokadtxt.TabIndex = 10;
            // 
            // katagoritxt
            // 
            this.katagoritxt.Location = new System.Drawing.Point(227, 52);
            this.katagoritxt.Name = "katagoritxt";
            this.katagoritxt.Size = new System.Drawing.Size(131, 29);
            this.katagoritxt.TabIndex = 12;
            this.katagoritxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(227, 109);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(131, 29);
            this.markatxt.TabIndex = 13;
            // 
            // alıştxt
            // 
            this.alıştxt.Location = new System.Drawing.Point(227, 166);
            this.alıştxt.Name = "alıştxt";
            this.alıştxt.Size = new System.Drawing.Size(131, 29);
            this.alıştxt.TabIndex = 14;
            // 
            // satıştxt
            // 
            this.satıştxt.Location = new System.Drawing.Point(122, 223);
            this.satıştxt.Name = "satıştxt";
            this.satıştxt.Size = new System.Drawing.Size(131, 29);
            this.satıştxt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 93);
            this.button1.TabIndex = 16;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miktartxt
            // 
            this.miktartxt.Location = new System.Drawing.Point(12, 166);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(136, 29);
            this.miktartxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(575, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 2);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(577, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(8, 2);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // frmstokgüncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(383, 389);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.miktartxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.satıştxt);
            this.Controls.Add(this.alıştxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.katagoritxt);
            this.Controls.Add(this.stokadtxt);
            this.Controls.Add(this.stokkodutxt);
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
            this.Name = "frmstokgüncel";
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.frmstokgüncel_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmstokgüncel_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stokkodutxt;
        private System.Windows.Forms.TextBox stokadtxt;
        private System.Windows.Forms.TextBox katagoritxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox alıştxt;
        private System.Windows.Forms.TextBox satıştxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}