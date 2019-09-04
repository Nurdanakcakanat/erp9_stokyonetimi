namespace Sy.Forms
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nUdFiyat = new System.Windows.Forms.NumericUpDown();
            this.nUdKritikStok = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lblbilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUdFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdKritikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kritik Stok";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(132, 31);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(120, 29);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // nUdFiyat
            // 
            this.nUdFiyat.DecimalPlaces = 2;
            this.nUdFiyat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUdFiyat.Location = new System.Drawing.Point(132, 72);
            this.nUdFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUdFiyat.Name = "nUdFiyat";
            this.nUdFiyat.Size = new System.Drawing.Size(120, 29);
            this.nUdFiyat.TabIndex = 4;
            this.nUdFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nUdKritikStok
            // 
            this.nUdKritikStok.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUdKritikStok.Location = new System.Drawing.Point(132, 109);
            this.nUdKritikStok.Name = "nUdKritikStok";
            this.nUdKritikStok.Size = new System.Drawing.Size(120, 29);
            this.nUdKritikStok.TabIndex = 5;
            this.nUdKritikStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKaydet.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(151, 158);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 44);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAra.Location = new System.Drawing.Point(341, 26);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(201, 29);
            this.txtAra.TabIndex = 7;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 23;
            this.lstUrunler.Location = new System.Drawing.Point(341, 66);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(201, 280);
            this.lstUrunler.TabIndex = 8;
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblbilgi.Location = new System.Drawing.Point(24, 225);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(243, 20);
            this.lblbilgi.TabIndex = 9;
            this.lblbilgi.Text = "lblBilgi burada ürünlerin bilgisini vereceğiz.";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 404);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nUdKritikStok);
            this.Controls.Add(this.nUdFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nUdFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdKritikStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nUdFiyat;
        private System.Windows.Forms.NumericUpDown nUdKritikStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label lblbilgi;
    }
}