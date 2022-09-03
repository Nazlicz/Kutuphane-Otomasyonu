
namespace KutuphaneOtomasyonu
{
    partial class PersonelIslemleri
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
            this.PersonelID = new System.Windows.Forms.TextBox();
            this.PersonelSifre = new System.Windows.Forms.TextBox();
            this.PersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // PersonelID
            // 
            this.PersonelID.Location = new System.Drawing.Point(116, 57);
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Size = new System.Drawing.Size(156, 22);
            this.PersonelID.TabIndex = 2;
            // 
            // PersonelSifre
            // 
            this.PersonelSifre.Location = new System.Drawing.Point(116, 93);
            this.PersonelSifre.Name = "PersonelSifre";
            this.PersonelSifre.Size = new System.Drawing.Size(156, 22);
            this.PersonelSifre.TabIndex = 3;
            // 
            // PersonelGiris
            // 
            this.PersonelGiris.Location = new System.Drawing.Point(73, 145);
            this.PersonelGiris.Name = "PersonelGiris";
            this.PersonelGiris.Size = new System.Drawing.Size(143, 23);
            this.PersonelGiris.TabIndex = 4;
            this.PersonelGiris.Text = "GİRİŞ";
            this.PersonelGiris.UseVisualStyleBackColor = true;
            this.PersonelGiris.Click += new System.EventHandler(this.PersonelGiris_Click);
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 194);
            this.Controls.Add(this.PersonelGiris);
            this.Controls.Add(this.PersonelSifre);
            this.Controls.Add(this.PersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonelID;
        private System.Windows.Forms.TextBox PersonelSifre;
        private System.Windows.Forms.Button PersonelGiris;
    }
}