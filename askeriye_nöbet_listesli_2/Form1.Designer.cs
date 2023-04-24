namespace askeriye_nöbet_listesli_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nobetlistesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.askeriyeDataSet1 = new askeriye_nöbet_listesli_2.askeriyeDataSet1();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnrandom = new System.Windows.Forms.Button();
            this.nobet_listesiTableAdapter = new askeriye_nöbet_listesli_2.askeriyeDataSet1TableAdapters.nobet_listesiTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnrdn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobetlistesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.askeriyeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "soyad";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(19, 107);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(115, 107);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(66, 136);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nobetlistesiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(218, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 198);
            this.dataGridView1.TabIndex = 5;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nobetlistesiBindingSource
            // 
            this.nobetlistesiBindingSource.DataMember = "nobet_listesi";
            this.nobetlistesiBindingSource.DataSource = this.askeriyeDataSet1;
            // 
            // askeriyeDataSet1
            // 
            this.askeriyeDataSet1.DataSetName = "askeriyeDataSet1";
            this.askeriyeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(77, 19);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(77, 46);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(534, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 164);
            this.listBox1.TabIndex = 8;
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(534, 19);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(75, 23);
            this.btnrandom.TabIndex = 9;
            this.btnrandom.Text = "listele";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // nobet_listesiTableAdapter
            // 
            this.nobet_listesiTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(676, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(137, 164);
            this.listBox2.TabIndex = 11;
            // 
            // btnrdn
            // 
            this.btnrdn.Location = new System.Drawing.Point(676, 18);
            this.btnrdn.Name = "btnrdn";
            this.btnrdn.Size = new System.Drawing.Size(75, 23);
            this.btnrdn.TabIndex = 12;
            this.btnrdn.Text = "random";
            this.btnrdn.UseVisualStyleBackColor = true;
            this.btnrdn.Click += new System.EventHandler(this.btnrdn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 229);
            this.Controls.Add(this.btnrdn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobetlistesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.askeriyeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnrandom;
        private askeriyeDataSet1 askeriyeDataSet1;
        private System.Windows.Forms.BindingSource nobetlistesiBindingSource;
        private askeriyeDataSet1TableAdapters.nobet_listesiTableAdapter nobet_listesiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnrdn;
    }
}

