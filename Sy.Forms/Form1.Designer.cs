namespace Sy.Forms
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
            this.gRbGiris = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.lbliSim = new System.Windows.Forms.Label();
            this.gRbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gRbGiris
            // 
            this.gRbGiris.Controls.Add(this.btnKayıtOl);
            this.gRbGiris.Controls.Add(this.btnGirisYap);
            this.gRbGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gRbGiris.Location = new System.Drawing.Point(12, 12);
            this.gRbGiris.Name = "gRbGiris";
            this.gRbGiris.Size = new System.Drawing.Size(282, 135);
            this.gRbGiris.TabIndex = 0;
            this.gRbGiris.TabStop = false;
            this.gRbGiris.Text = "Giriş";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Aqua;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(6, 31);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(112, 79);
            this.btnGirisYap.TabIndex = 1;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.Aqua;
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.Location = new System.Drawing.Point(140, 31);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(112, 79);
            this.btnKayıtOl.TabIndex = 1;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // lbliSim
            // 
            this.lbliSim.AutoSize = true;
            this.lbliSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbliSim.ForeColor = System.Drawing.Color.Teal;
            this.lbliSim.Location = new System.Drawing.Point(319, 12);
            this.lbliSim.Name = "lbliSim";
            this.lbliSim.Size = new System.Drawing.Size(187, 22);
            this.lbliSim.TabIndex = 1;
            this.lbliSim.Text = "Hoşgeldin : Kamil Fıdıl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 306);
            this.Controls.Add(this.lbliSim);
            this.Controls.Add(this.gRbGiris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gRbGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gRbGiris;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lbliSim;
    }
}

