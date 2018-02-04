namespace YurtProjesi
{
    partial class frmOgrenciListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögenciTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciVeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrencilerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet6 = new YurtProjesi.YurtOtomasyonuDataSet6();
            this.ögrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet3 = new YurtProjesi.YurtOtomasyonuDataSet3();
            this.ögrencilerTableAdapter = new YurtProjesi.YurtOtomasyonuDataSet3TableAdapters.ögrencilerTableAdapter();
            this.yurtOtomasyonuDataSet4 = new YurtProjesi.YurtOtomasyonuDataSet4();
            this.ögrencilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ögrencilerTableAdapter1 = new YurtProjesi.YurtOtomasyonuDataSet4TableAdapters.ögrencilerTableAdapter();
            this.yurtOtomasyonuDataSet5 = new YurtProjesi.YurtOtomasyonuDataSet5();
            this.ögrencilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ögrencilerTableAdapter2 = new YurtProjesi.YurtOtomasyonuDataSet5TableAdapters.ögrencilerTableAdapter();
            this.ögrencilerTableAdapter3 = new YurtProjesi.YurtOtomasyonuDataSet6TableAdapters.ögrencilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ögrenciIdDataGridViewTextBoxColumn,
            this.ögrenciAdDataGridViewTextBoxColumn,
            this.ögrenciSoyadDataGridViewTextBoxColumn,
            this.ögenciTcDataGridViewTextBoxColumn,
            this.ögrenciTelefonDataGridViewTextBoxColumn,
            this.ögrenciDogumDataGridViewTextBoxColumn,
            this.ögrenciBolumDataGridViewTextBoxColumn,
            this.ögrenciMailDataGridViewTextBoxColumn,
            this.ögrenciOdaNoDataGridViewTextBoxColumn,
            this.ögrenciVeliDataGridViewTextBoxColumn,
            this.ögrenciVeliTelefonDataGridViewTextBoxColumn,
            this.ögrenciVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ögrencilerBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ögrenciIdDataGridViewTextBoxColumn
            // 
            this.ögrenciIdDataGridViewTextBoxColumn.DataPropertyName = "ögrenciId";
            this.ögrenciIdDataGridViewTextBoxColumn.HeaderText = "ögrenciId";
            this.ögrenciIdDataGridViewTextBoxColumn.Name = "ögrenciIdDataGridViewTextBoxColumn";
            this.ögrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ögrenciAdDataGridViewTextBoxColumn
            // 
            this.ögrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ögrenciAd";
            this.ögrenciAdDataGridViewTextBoxColumn.HeaderText = "ögrenciAd";
            this.ögrenciAdDataGridViewTextBoxColumn.Name = "ögrenciAdDataGridViewTextBoxColumn";
            // 
            // ögrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ögrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "ögrenciSoyad";
            this.ögrenciSoyadDataGridViewTextBoxColumn.HeaderText = "ögrenciSoyad";
            this.ögrenciSoyadDataGridViewTextBoxColumn.Name = "ögrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ögenciTcDataGridViewTextBoxColumn
            // 
            this.ögenciTcDataGridViewTextBoxColumn.DataPropertyName = "ögenciTc";
            this.ögenciTcDataGridViewTextBoxColumn.HeaderText = "ögenciTc";
            this.ögenciTcDataGridViewTextBoxColumn.Name = "ögenciTcDataGridViewTextBoxColumn";
            // 
            // ögrenciTelefonDataGridViewTextBoxColumn
            // 
            this.ögrenciTelefonDataGridViewTextBoxColumn.DataPropertyName = "ögrenciTelefon";
            this.ögrenciTelefonDataGridViewTextBoxColumn.HeaderText = "ögrenciTelefon";
            this.ögrenciTelefonDataGridViewTextBoxColumn.Name = "ögrenciTelefonDataGridViewTextBoxColumn";
            // 
            // ögrenciDogumDataGridViewTextBoxColumn
            // 
            this.ögrenciDogumDataGridViewTextBoxColumn.DataPropertyName = "ögrenciDogum";
            this.ögrenciDogumDataGridViewTextBoxColumn.HeaderText = "ögrenciDogum";
            this.ögrenciDogumDataGridViewTextBoxColumn.Name = "ögrenciDogumDataGridViewTextBoxColumn";
            // 
            // ögrenciBolumDataGridViewTextBoxColumn
            // 
            this.ögrenciBolumDataGridViewTextBoxColumn.DataPropertyName = "ögrenciBolum";
            this.ögrenciBolumDataGridViewTextBoxColumn.HeaderText = "ögrenciBolum";
            this.ögrenciBolumDataGridViewTextBoxColumn.Name = "ögrenciBolumDataGridViewTextBoxColumn";
            // 
            // ögrenciMailDataGridViewTextBoxColumn
            // 
            this.ögrenciMailDataGridViewTextBoxColumn.DataPropertyName = "ögrenciMail";
            this.ögrenciMailDataGridViewTextBoxColumn.HeaderText = "ögrenciMail";
            this.ögrenciMailDataGridViewTextBoxColumn.Name = "ögrenciMailDataGridViewTextBoxColumn";
            // 
            // ögrenciOdaNoDataGridViewTextBoxColumn
            // 
            this.ögrenciOdaNoDataGridViewTextBoxColumn.DataPropertyName = "ögrenciOdaNo";
            this.ögrenciOdaNoDataGridViewTextBoxColumn.HeaderText = "ögrenciOdaNo";
            this.ögrenciOdaNoDataGridViewTextBoxColumn.Name = "ögrenciOdaNoDataGridViewTextBoxColumn";
            // 
            // ögrenciVeliDataGridViewTextBoxColumn
            // 
            this.ögrenciVeliDataGridViewTextBoxColumn.DataPropertyName = "ögrenciVeli";
            this.ögrenciVeliDataGridViewTextBoxColumn.HeaderText = "ögrenciVeli";
            this.ögrenciVeliDataGridViewTextBoxColumn.Name = "ögrenciVeliDataGridViewTextBoxColumn";
            // 
            // ögrenciVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ögrenciVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "ögrenciVeliTelefon";
            this.ögrenciVeliTelefonDataGridViewTextBoxColumn.HeaderText = "ögrenciVeliTelefon";
            this.ögrenciVeliTelefonDataGridViewTextBoxColumn.Name = "ögrenciVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ögrenciVeliAdresDataGridViewTextBoxColumn
            // 
            this.ögrenciVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "ögrenciVeliAdres";
            this.ögrenciVeliAdresDataGridViewTextBoxColumn.HeaderText = "ögrenciVeliAdres";
            this.ögrenciVeliAdresDataGridViewTextBoxColumn.Name = "ögrenciVeliAdresDataGridViewTextBoxColumn";
            // 
            // ögrencilerBindingSource3
            // 
            this.ögrencilerBindingSource3.DataMember = "ögrenciler";
            this.ögrencilerBindingSource3.DataSource = this.yurtOtomasyonuDataSet6;
            // 
            // yurtOtomasyonuDataSet6
            // 
            this.yurtOtomasyonuDataSet6.DataSetName = "YurtOtomasyonuDataSet6";
            this.yurtOtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrencilerBindingSource
            // 
            this.ögrencilerBindingSource.DataMember = "ögrenciler";
            this.ögrencilerBindingSource.DataSource = this.yurtOtomasyonuDataSet3;
            // 
            // yurtOtomasyonuDataSet3
            // 
            this.yurtOtomasyonuDataSet3.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrencilerTableAdapter
            // 
            this.ögrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet4
            // 
            this.yurtOtomasyonuDataSet4.DataSetName = "YurtOtomasyonuDataSet4";
            this.yurtOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrencilerBindingSource1
            // 
            this.ögrencilerBindingSource1.DataMember = "ögrenciler";
            this.ögrencilerBindingSource1.DataSource = this.yurtOtomasyonuDataSet4;
            // 
            // ögrencilerTableAdapter1
            // 
            this.ögrencilerTableAdapter1.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet5
            // 
            this.yurtOtomasyonuDataSet5.DataSetName = "YurtOtomasyonuDataSet5";
            this.yurtOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrencilerBindingSource2
            // 
            this.ögrencilerBindingSource2.DataMember = "ögrenciler";
            this.ögrencilerBindingSource2.DataSource = this.yurtOtomasyonuDataSet5;
            // 
            // ögrencilerTableAdapter2
            // 
            this.ögrencilerTableAdapter2.ClearBeforeFill = true;
            // 
            // ögrencilerTableAdapter3
            // 
            this.ögrencilerTableAdapter3.ClearBeforeFill = true;
            // 
            // frmOgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOgrenciListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.frmOgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrencilerBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource;
        private YurtOtomasyonuDataSet3TableAdapters.ögrencilerTableAdapter ögrencilerTableAdapter;
        private YurtOtomasyonuDataSet4 yurtOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource1;
        private YurtOtomasyonuDataSet4TableAdapters.ögrencilerTableAdapter ögrencilerTableAdapter1;
        private YurtOtomasyonuDataSet5 yurtOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource2;
        private YurtOtomasyonuDataSet5TableAdapters.ögrencilerTableAdapter ögrencilerTableAdapter2;
        private YurtOtomasyonuDataSet6 yurtOtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource ögrencilerBindingSource3;
        private YurtOtomasyonuDataSet6TableAdapters.ögrencilerTableAdapter ögrencilerTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögenciTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciVeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciVeliAdresDataGridViewTextBoxColumn;
    }
}