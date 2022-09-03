
namespace KutuphaneOtomasyonu
{
    partial class OduncAlma
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
            this.components = new System.ComponentModel.Container();
            this.kutuphaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonuDataSet2 = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet2();
            this.UyeBilgi = new System.Windows.Forms.GroupBox();
            this.SoyisimTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IsimTxt = new System.Windows.Forms.TextBox();
            this.TcTxt = new System.Windows.Forms.TextBox();
            this.KitapBilgi = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.YazarTxt = new System.Windows.Forms.TextBox();
            this.KitapTxt = new System.Windows.Forms.TextBox();
            this.BarkodTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OduncAl = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.kutuphaneTableAdapter = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet2TableAdapters.KutuphaneTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet2)).BeginInit();
            this.UyeBilgi.SuspendLayout();
            this.KitapBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // kutuphaneBindingSource
            // 
            this.kutuphaneBindingSource.DataMember = "Kutuphane";
            this.kutuphaneBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet2;
            // 
            // kütüphaneOtomasyonuDataSet2
            // 
            this.kütüphaneOtomasyonuDataSet2.DataSetName = "KütüphaneOtomasyonuDataSet2";
            this.kütüphaneOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UyeBilgi
            // 
            this.UyeBilgi.Controls.Add(this.SoyisimTxt);
            this.UyeBilgi.Controls.Add(this.label8);
            this.UyeBilgi.Controls.Add(this.label2);
            this.UyeBilgi.Controls.Add(this.label1);
            this.UyeBilgi.Controls.Add(this.IsimTxt);
            this.UyeBilgi.Controls.Add(this.TcTxt);
            this.UyeBilgi.Location = new System.Drawing.Point(22, 12);
            this.UyeBilgi.Name = "UyeBilgi";
            this.UyeBilgi.Size = new System.Drawing.Size(232, 148);
            this.UyeBilgi.TabIndex = 1;
            this.UyeBilgi.TabStop = false;
            this.UyeBilgi.Text = "Üye Bilgileri";
            // 
            // SoyisimTxt
            // 
            this.SoyisimTxt.Location = new System.Drawing.Point(113, 100);
            this.SoyisimTxt.Name = "SoyisimTxt";
            this.SoyisimTxt.Size = new System.Drawing.Size(100, 22);
            this.SoyisimTxt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc No:";
            // 
            // IsimTxt
            // 
            this.IsimTxt.Location = new System.Drawing.Point(113, 72);
            this.IsimTxt.Name = "IsimTxt";
            this.IsimTxt.Size = new System.Drawing.Size(100, 22);
            this.IsimTxt.TabIndex = 1;
            // 
            // TcTxt
            // 
            this.TcTxt.Location = new System.Drawing.Point(113, 43);
            this.TcTxt.Name = "TcTxt";
            this.TcTxt.Size = new System.Drawing.Size(100, 22);
            this.TcTxt.TabIndex = 0;
            this.TcTxt.TextChanged += new System.EventHandler(this.TcTxt_TextChanged);
            // 
            // KitapBilgi
            // 
            this.KitapBilgi.Controls.Add(this.dateTimePicker1);
            this.KitapBilgi.Controls.Add(this.label7);
            this.KitapBilgi.Controls.Add(this.label6);
            this.KitapBilgi.Controls.Add(this.dateTimePicker2);
            this.KitapBilgi.Controls.Add(this.label5);
            this.KitapBilgi.Controls.Add(this.YazarTxt);
            this.KitapBilgi.Controls.Add(this.KitapTxt);
            this.KitapBilgi.Controls.Add(this.BarkodTxt);
            this.KitapBilgi.Controls.Add(this.label4);
            this.KitapBilgi.Controls.Add(this.label3);
            this.KitapBilgi.Location = new System.Drawing.Point(22, 166);
            this.KitapBilgi.Name = "KitapBilgi";
            this.KitapBilgi.Size = new System.Drawing.Size(232, 205);
            this.KitapBilgi.TabIndex = 2;
            this.KitapBilgi.TabStop = false;
            this.KitapBilgi.Text = "Kitap Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "İade Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alım Tarihi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 158);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yazar Adı:";
            // 
            // YazarTxt
            // 
            this.YazarTxt.Location = new System.Drawing.Point(113, 102);
            this.YazarTxt.Name = "YazarTxt";
            this.YazarTxt.Size = new System.Drawing.Size(100, 22);
            this.YazarTxt.TabIndex = 4;
            // 
            // KitapTxt
            // 
            this.KitapTxt.Location = new System.Drawing.Point(113, 74);
            this.KitapTxt.Name = "KitapTxt";
            this.KitapTxt.Size = new System.Drawing.Size(100, 22);
            this.KitapTxt.TabIndex = 3;
            // 
            // BarkodTxt
            // 
            this.BarkodTxt.Location = new System.Drawing.Point(113, 46);
            this.BarkodTxt.Name = "BarkodTxt";
            this.BarkodTxt.Size = new System.Drawing.Size(100, 22);
            this.BarkodTxt.TabIndex = 2;
            this.BarkodTxt.TextChanged += new System.EventHandler(this.BarkodTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barkod No:";
            // 
            // OduncAl
            // 
            this.OduncAl.Location = new System.Drawing.Point(145, 414);
            this.OduncAl.Name = "OduncAl";
            this.OduncAl.Size = new System.Drawing.Size(109, 31);
            this.OduncAl.TabIndex = 3;
            this.OduncAl.Text = "Ödünç Al";
            this.OduncAl.UseVisualStyleBackColor = true;
            this.OduncAl.Click += new System.EventHandler(this.OduncAl_Click);
            // 
            // Iptal
            // 
            this.Iptal.Location = new System.Drawing.Point(22, 414);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(109, 31);
            this.Iptal.TabIndex = 4;
            this.Iptal.Text = "İPTAL";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // kutuphaneTableAdapter
            // 
            this.kutuphaneTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kitapları Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OduncAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.OduncAl);
            this.Controls.Add(this.KitapBilgi);
            this.Controls.Add(this.UyeBilgi);
            this.Name = "OduncAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Alma";
            this.Load += new System.EventHandler(this.OduncAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet2)).EndInit();
            this.UyeBilgi.ResumeLayout(false);
            this.UyeBilgi.PerformLayout();
            this.KitapBilgi.ResumeLayout(false);
            this.KitapBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox UyeBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IsimTxt;
        private System.Windows.Forms.TextBox TcTxt;
        private System.Windows.Forms.GroupBox KitapBilgi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox YazarTxt;
        private System.Windows.Forms.TextBox KitapTxt;
        private System.Windows.Forms.TextBox BarkodTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OduncAl;
        private System.Windows.Forms.Button Iptal;
        private KütüphaneOtomasyonuDataSet2 kütüphaneOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource kutuphaneBindingSource;
        private KütüphaneOtomasyonuDataSet2TableAdapters.KutuphaneTableAdapter kutuphaneTableAdapter;
        private System.Windows.Forms.TextBox SoyisimTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}