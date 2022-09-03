
namespace KutuphaneOtomasyonu
{
    partial class KitapListesi
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
            this.kütüphaneOtomasyonuDataSet3 = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet3();
            this.kitapTableAdapter = new KutuphaneOtomasyonu.KütüphaneOtomasyonuDataSet3TableAdapters.KitapTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet3)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 400);
            this.dataGridView1.TabIndex = 0;
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
            this.kitapBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet3;
            // 
            // kütüphaneOtomasyonuDataSet3
            // 
            this.kütüphaneOtomasyonuDataSet3.DataSetName = "KütüphaneOtomasyonuDataSet3";
            this.kütüphaneOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İsmi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapListesi";
            this.Load += new System.EventHandler(this.KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonuDataSet3 kütüphaneOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KütüphaneOtomasyonuDataSet3TableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktiflikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}