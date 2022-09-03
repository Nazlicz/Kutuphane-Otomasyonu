
namespace KutuphaneOtomasyonu
{
    partial class UyeListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kütüphaneOtomasyonuDataSet = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeTableAdapter = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSetTableAdapters.UyeTableAdapter();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İptal = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.AramaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Button();
            this.YeniKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.yasDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(169, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kütüphaneOtomasyonuDataSet
            // 
            this.kütüphaneOtomasyonuDataSet.DataSetName = "KütüphaneOtomasyonuDataSet";
            this.kütüphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "Uye";
            this.uyeBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet;
            // 
            // uyeTableAdapter
            // 
            this.uyeTableAdapter.ClearBeforeFill = true;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.Width = 125;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            this.yasDataGridViewTextBoxColumn.DataPropertyName = "yas";
            this.yasDataGridViewTextBoxColumn.HeaderText = "yas";
            this.yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            this.yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            this.epostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // İptal
            // 
            this.İptal.Location = new System.Drawing.Point(38, 226);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(114, 29);
            this.İptal.TabIndex = 35;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.İptal_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(38, 86);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(114, 29);
            this.Guncelle.TabIndex = 34;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(38, 156);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(114, 29);
            this.Sil.TabIndex = 36;
            this.Sil.Text = "Kaydı Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // AramaTxt
            // 
            this.AramaTxt.Location = new System.Drawing.Point(38, 58);
            this.AramaTxt.Name = "AramaTxt";
            this.AramaTxt.Size = new System.Drawing.Size(114, 22);
            this.AramaTxt.TabIndex = 38;
            this.AramaTxt.TextChanged += new System.EventHandler(this.AramaTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tc:";
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(38, 191);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(114, 29);
            this.Yenile.TabIndex = 39;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // YeniKayit
            // 
            this.YeniKayit.Location = new System.Drawing.Point(38, 121);
            this.YeniKayit.Name = "YeniKayit";
            this.YeniKayit.Size = new System.Drawing.Size(114, 29);
            this.YeniKayit.TabIndex = 40;
            this.YeniKayit.Text = "Yeni Kayıt";
            this.YeniKayit.UseVisualStyleBackColor = true;
            this.YeniKayit.Click += new System.EventHandler(this.YeniKayit_Click);
            // 
            // UyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 409);
            this.Controls.Add(this.YeniKayit);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.AramaTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeListeleme";
            this.Load += new System.EventHandler(this.UyeListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonuDataSet kütüphaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private KütüphaneOtomasyonuDataSetTableAdapters.UyeTableAdapter uyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.TextBox AramaTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Button YeniKayit;
    }
}