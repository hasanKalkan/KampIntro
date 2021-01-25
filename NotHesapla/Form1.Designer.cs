
namespace NotHesapla
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
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnOrtalamaHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDersAdedi = new System.Windows.Forms.TextBox();
            this.btnDersArttir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(132, 26);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 0;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnOrtalamaHesapla
            // 
            this.btnOrtalamaHesapla.Location = new System.Drawing.Point(294, 26);
            this.btnOrtalamaHesapla.Name = "btnOrtalamaHesapla";
            this.btnOrtalamaHesapla.Size = new System.Drawing.Size(115, 23);
            this.btnOrtalamaHesapla.TabIndex = 1;
            this.btnOrtalamaHesapla.Text = "Ortalama Hesapla";
            this.btnOrtalamaHesapla.UseVisualStyleBackColor = true;
            this.btnOrtalamaHesapla.Click += new System.EventHandler(this.btnOrtalamaHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtDersAdedi
            // 
            this.txtDersAdedi.Location = new System.Drawing.Point(32, 29);
            this.txtDersAdedi.Name = "txtDersAdedi";
            this.txtDersAdedi.Size = new System.Drawing.Size(75, 20);
            this.txtDersAdedi.TabIndex = 3;
            // 
            // btnDersArttir
            // 
            this.btnDersArttir.Location = new System.Drawing.Point(213, 26);
            this.btnDersArttir.Name = "btnDersArttir";
            this.btnDersArttir.Size = new System.Drawing.Size(75, 23);
            this.btnDersArttir.TabIndex = 4;
            this.btnDersArttir.Text = "Ders Arttır";
            this.btnDersArttir.UseVisualStyleBackColor = true;
            this.btnDersArttir.Click += new System.EventHandler(this.btnDersArttir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.btnDersArttir);
            this.Controls.Add(this.txtDersAdedi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrtalamaHesapla);
            this.Controls.Add(this.btnDersEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnOrtalamaHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDersAdedi;
        private System.Windows.Forms.Button btnDersArttir;
    }
}

