
namespace KutuphaneOtomasyonu
{
    partial class KitapListeleme
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
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktiflikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonuDataSet1 = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet1();
            this.kitapTableAdapter = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet1TableAdapters.KitapTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.yeniKayit = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            this.AramaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodNoDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.rafNoDataGridViewTextBoxColumn,
            this.aktiflikDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(222, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "barkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "barkodNo";
            this.barkodNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            this.barkodNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            this.yazarAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "tur";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.Width = 125;
            // 
            // rafNoDataGridViewTextBoxColumn
            // 
            this.rafNoDataGridViewTextBoxColumn.DataPropertyName = "rafNo";
            this.rafNoDataGridViewTextBoxColumn.HeaderText = "rafNo";
            this.rafNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rafNoDataGridViewTextBoxColumn.Name = "rafNoDataGridViewTextBoxColumn";
            this.rafNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktiflikDataGridViewTextBoxColumn
            // 
            this.aktiflikDataGridViewTextBoxColumn.DataPropertyName = "aktiflik";
            this.aktiflikDataGridViewTextBoxColumn.HeaderText = "aktiflik";
            this.aktiflikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aktiflikDataGridViewTextBoxColumn.Name = "aktiflikDataGridViewTextBoxColumn";
            this.aktiflikDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "kayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "kayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet1;
            // 
            // kütüphaneOtomasyonuDataSet1
            // 
            this.kütüphaneOtomasyonuDataSet1.DataSetName = "KütüphaneOtomasyonuDataSet1";
            this.kütüphaneOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 31;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(88, 101);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(128, 33);
            this.Guncelle.TabIndex = 30;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(88, 179);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(128, 31);
            this.Sil.TabIndex = 33;
            this.Sil.Text = "Kitap Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // yeniKayit
            // 
            this.yeniKayit.Location = new System.Drawing.Point(88, 140);
            this.yeniKayit.Name = "yeniKayit";
            this.yeniKayit.Size = new System.Drawing.Size(128, 33);
            this.yeniKayit.TabIndex = 34;
            this.yeniKayit.Text = "Yeni Kitap Kaydı";
            this.yeniKayit.UseVisualStyleBackColor = true;
            this.yeniKayit.Click += new System.EventHandler(this.yeniKayit_Click);
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(88, 216);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(128, 31);
            this.Yenile.TabIndex = 35;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // AramaTxt
            // 
            this.AramaTxt.Location = new System.Drawing.Point(88, 73);
            this.AramaTxt.Name = "AramaTxt";
            this.AramaTxt.Size = new System.Drawing.Size(128, 22);
            this.AramaTxt.TabIndex = 40;
            this.AramaTxt.TextChanged += new System.EventHandler(this.AramaTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Barkod No:";
            // 
            // KitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 388);
            this.Controls.Add(this.AramaTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.yeniKayit);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapListeleme";
            this.Load += new System.EventHandler(this.KitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonuDataSet1 kütüphaneOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KütüphaneOtomasyonuDataSet1TableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktiflikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button yeniKayit;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.TextBox AramaTxt;
        private System.Windows.Forms.Label label9;
    }
}