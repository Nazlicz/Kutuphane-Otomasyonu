
namespace KutuphaneOtomasyonu
{
    partial class PersonelPanel
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
            this.UyeListeleme = new System.Windows.Forms.Button();
            this.KitapListeleme = new System.Windows.Forms.Button();
            this.OduncKitap = new System.Windows.Forms.Button();
            this.IadeKitap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UyeListeleme
            // 
            this.UyeListeleme.Location = new System.Drawing.Point(34, 22);
            this.UyeListeleme.Name = "UyeListeleme";
            this.UyeListeleme.Size = new System.Drawing.Size(207, 38);
            this.UyeListeleme.TabIndex = 0;
            this.UyeListeleme.Text = "Üye Listeleme";
            this.UyeListeleme.UseVisualStyleBackColor = true;
            this.UyeListeleme.Click += new System.EventHandler(this.UyeListeleme_Click);
            // 
            // KitapListeleme
            // 
            this.KitapListeleme.Location = new System.Drawing.Point(34, 78);
            this.KitapListeleme.Name = "KitapListeleme";
            this.KitapListeleme.Size = new System.Drawing.Size(207, 38);
            this.KitapListeleme.TabIndex = 1;
            this.KitapListeleme.Text = "Kitap Listeleme";
            this.KitapListeleme.UseVisualStyleBackColor = true;
            this.KitapListeleme.Click += new System.EventHandler(this.KitapListeleme_Click_1);
            // 
            // OduncKitap
            // 
            this.OduncKitap.Location = new System.Drawing.Point(34, 134);
            this.OduncKitap.Name = "OduncKitap";
            this.OduncKitap.Size = new System.Drawing.Size(207, 38);
            this.OduncKitap.TabIndex = 2;
            this.OduncKitap.Text = "Ödünç Kitap Listeleme";
            this.OduncKitap.UseVisualStyleBackColor = true;
            this.OduncKitap.Click += new System.EventHandler(this.OduncKitap_Click);
            // 
            // IadeKitap
            // 
            this.IadeKitap.Location = new System.Drawing.Point(34, 190);
            this.IadeKitap.Name = "IadeKitap";
            this.IadeKitap.Size = new System.Drawing.Size(207, 38);
            this.IadeKitap.TabIndex = 3;
            this.IadeKitap.Text = "İade Kitap Listeleme";
            this.IadeKitap.UseVisualStyleBackColor = true;
            this.IadeKitap.Click += new System.EventHandler(this.IadeKitap_Click);
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 261);
            this.Controls.Add(this.IadeKitap);
            this.Controls.Add(this.OduncKitap);
            this.Controls.Add(this.KitapListeleme);
            this.Controls.Add(this.UyeListeleme);
            this.Name = "PersonelPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UyeListeleme;
        private System.Windows.Forms.Button KitapListeleme;
        private System.Windows.Forms.Button OduncKitap;
        private System.Windows.Forms.Button IadeKitap;
    }
}