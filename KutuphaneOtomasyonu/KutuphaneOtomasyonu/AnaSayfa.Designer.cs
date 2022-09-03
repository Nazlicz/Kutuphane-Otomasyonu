
namespace KutuphaneOtomasyonu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonelButton = new System.Windows.Forms.Button();
            this.UyeButton = new System.Windows.Forms.Button();
            this.KitapEkleme = new System.Windows.Forms.Button();
            this.OduncAlma = new System.Windows.Forms.Button();
            this.iade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonelButton
            // 
            this.PersonelButton.Location = new System.Drawing.Point(39, 44);
            this.PersonelButton.Name = "PersonelButton";
            this.PersonelButton.Size = new System.Drawing.Size(188, 39);
            this.PersonelButton.TabIndex = 0;
            this.PersonelButton.Text = "Personel İşlemleri";
            this.PersonelButton.UseVisualStyleBackColor = true;
            this.PersonelButton.Click += new System.EventHandler(this.PersonelButton_Click);
            // 
            // UyeButton
            // 
            this.UyeButton.Location = new System.Drawing.Point(39, 103);
            this.UyeButton.Name = "UyeButton";
            this.UyeButton.Size = new System.Drawing.Size(188, 39);
            this.UyeButton.TabIndex = 1;
            this.UyeButton.Text = "Yeni Üye";
            this.UyeButton.UseVisualStyleBackColor = true;
            this.UyeButton.Click += new System.EventHandler(this.UyeButton_Click);
            // 
            // KitapEkleme
            // 
            this.KitapEkleme.Location = new System.Drawing.Point(39, 162);
            this.KitapEkleme.Name = "KitapEkleme";
            this.KitapEkleme.Size = new System.Drawing.Size(188, 39);
            this.KitapEkleme.TabIndex = 2;
            this.KitapEkleme.Text = "Kitap Ekleme";
            this.KitapEkleme.UseVisualStyleBackColor = true;
            this.KitapEkleme.Click += new System.EventHandler(this.KitapEkleme_Click);
            // 
            // OduncAlma
            // 
            this.OduncAlma.Location = new System.Drawing.Point(39, 221);
            this.OduncAlma.Name = "OduncAlma";
            this.OduncAlma.Size = new System.Drawing.Size(188, 39);
            this.OduncAlma.TabIndex = 3;
            this.OduncAlma.Text = "Ödünç Alma";
            this.OduncAlma.UseVisualStyleBackColor = true;
            this.OduncAlma.Click += new System.EventHandler(this.OduncAlma_Click);
            // 
            // iade
            // 
            this.iade.Location = new System.Drawing.Point(39, 280);
            this.iade.Name = "iade";
            this.iade.Size = new System.Drawing.Size(188, 39);
            this.iade.TabIndex = 4;
            this.iade.Text = "Kitap İade";
            this.iade.UseVisualStyleBackColor = true;
            this.iade.Click += new System.EventHandler(this.iade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "KÜTÜPHANE OTOMASYONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(145, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create by Nazlıcan Çız";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iade);
            this.Controls.Add(this.OduncAlma);
            this.Controls.Add(this.KitapEkleme);
            this.Controls.Add(this.UyeButton);
            this.Controls.Add(this.PersonelButton);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonelButton;
        private System.Windows.Forms.Button UyeButton;
        private System.Windows.Forms.Button KitapEkleme;
        private System.Windows.Forms.Button OduncAlma;
        private System.Windows.Forms.Button iade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

