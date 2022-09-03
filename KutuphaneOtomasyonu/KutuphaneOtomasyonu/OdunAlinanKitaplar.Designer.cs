
namespace KutuphaneOtomasyonu
{
    partial class OdunAlinanKitaplar
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
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanKitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonuDataSet5 = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet5();
            this.alinanKitapTableAdapter = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet5TableAdapters.AlinanKitapTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinanKitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet5)).BeginInit();
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
            this.barkodNoDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.alimTarihiDataGridViewTextBoxColumn,
            this.iadeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alinanKitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(209, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 323);
            this.dataGridView1.TabIndex = 0;
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
            // alimTarihiDataGridViewTextBoxColumn
            // 
            this.alimTarihiDataGridViewTextBoxColumn.DataPropertyName = "alimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.HeaderText = "alimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alimTarihiDataGridViewTextBoxColumn.Name = "alimTarihiDataGridViewTextBoxColumn";
            this.alimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // iadeTarihiDataGridViewTextBoxColumn
            // 
            this.iadeTarihiDataGridViewTextBoxColumn.DataPropertyName = "iadeTarihi";
            this.iadeTarihiDataGridViewTextBoxColumn.HeaderText = "iadeTarihi";
            this.iadeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iadeTarihiDataGridViewTextBoxColumn.Name = "iadeTarihiDataGridViewTextBoxColumn";
            this.iadeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // alinanKitapBindingSource
            // 
            this.alinanKitapBindingSource.DataMember = "AlinanKitap";
            this.alinanKitapBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet5;
            // 
            // kütüphaneOtomasyonuDataSet5
            // 
            this.kütüphaneOtomasyonuDataSet5.DataSetName = "KütüphaneOtomasyonuDataSet5";
            this.kütüphaneOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alinanKitapTableAdapter
            // 
            this.alinanKitapTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(52, 75);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(137, 32);
            this.Guncelle.TabIndex = 3;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ödünç Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(52, 151);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(137, 32);
            this.Sil.TabIndex = 5;
            this.Sil.Text = "Kayıt Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(52, 189);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(137, 32);
            this.yenile.TabIndex = 6;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "İPTAL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OdunAlinanKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 367);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OdunAlinanKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Alınan Kitaplar";
            this.Load += new System.EventHandler(this.OdunAlinanKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinanKitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonuDataSet5 kütüphaneOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource alinanKitapBindingSource;
        private KütüphaneOtomasyonuDataSet5TableAdapters.AlinanKitapTableAdapter alinanKitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iadeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button button5;
    }
}