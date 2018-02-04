namespace YurtProjesi
{
    partial class frmGiderListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiderListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikFaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suFaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazFaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetFaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet7 = new YurtProjesi.YurtOtomasyonuDataSet7();
            this.giderlerTableAdapter = new YurtProjesi.YurtOtomasyonuDataSet7TableAdapters.giderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIdDataGridViewTextBoxColumn,
            this.elektrikFaturaDataGridViewTextBoxColumn,
            this.suFaturaDataGridViewTextBoxColumn,
            this.dogalgazFaturaDataGridViewTextBoxColumn,
            this.internetFaturaDataGridViewTextBoxColumn,
            this.gıdaTutarDataGridViewTextBoxColumn,
            this.personelTutarDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odemeIdDataGridViewTextBoxColumn
            // 
            this.odemeIdDataGridViewTextBoxColumn.DataPropertyName = "odemeId";
            this.odemeIdDataGridViewTextBoxColumn.HeaderText = "odemeId";
            this.odemeIdDataGridViewTextBoxColumn.Name = "odemeIdDataGridViewTextBoxColumn";
            this.odemeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektrikFaturaDataGridViewTextBoxColumn
            // 
            this.elektrikFaturaDataGridViewTextBoxColumn.DataPropertyName = "elektrikFatura";
            this.elektrikFaturaDataGridViewTextBoxColumn.HeaderText = "elektrikFatura";
            this.elektrikFaturaDataGridViewTextBoxColumn.Name = "elektrikFaturaDataGridViewTextBoxColumn";
            // 
            // suFaturaDataGridViewTextBoxColumn
            // 
            this.suFaturaDataGridViewTextBoxColumn.DataPropertyName = "suFatura";
            this.suFaturaDataGridViewTextBoxColumn.HeaderText = "suFatura";
            this.suFaturaDataGridViewTextBoxColumn.Name = "suFaturaDataGridViewTextBoxColumn";
            // 
            // dogalgazFaturaDataGridViewTextBoxColumn
            // 
            this.dogalgazFaturaDataGridViewTextBoxColumn.DataPropertyName = "dogalgazFatura";
            this.dogalgazFaturaDataGridViewTextBoxColumn.HeaderText = "dogalgazFatura";
            this.dogalgazFaturaDataGridViewTextBoxColumn.Name = "dogalgazFaturaDataGridViewTextBoxColumn";
            // 
            // internetFaturaDataGridViewTextBoxColumn
            // 
            this.internetFaturaDataGridViewTextBoxColumn.DataPropertyName = "internetFatura";
            this.internetFaturaDataGridViewTextBoxColumn.HeaderText = "internetFatura";
            this.internetFaturaDataGridViewTextBoxColumn.Name = "internetFaturaDataGridViewTextBoxColumn";
            // 
            // gıdaTutarDataGridViewTextBoxColumn
            // 
            this.gıdaTutarDataGridViewTextBoxColumn.DataPropertyName = "gıdaTutar";
            this.gıdaTutarDataGridViewTextBoxColumn.HeaderText = "gıdaTutar";
            this.gıdaTutarDataGridViewTextBoxColumn.Name = "gıdaTutarDataGridViewTextBoxColumn";
            // 
            // personelTutarDataGridViewTextBoxColumn
            // 
            this.personelTutarDataGridViewTextBoxColumn.DataPropertyName = "personelTutar";
            this.personelTutarDataGridViewTextBoxColumn.HeaderText = "personelTutar";
            this.personelTutarDataGridViewTextBoxColumn.Name = "personelTutarDataGridViewTextBoxColumn";
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "diger";
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "giderler";
            this.giderlerBindingSource.DataSource = this.yurtOtomasyonuDataSet7;
            // 
            // yurtOtomasyonuDataSet7
            // 
            this.yurtOtomasyonuDataSet7.DataSetName = "YurtOtomasyonuDataSet7";
            this.yurtOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmGiderListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 437);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGiderListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Listesi";
            this.Load += new System.EventHandler(this.frmGiderListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet7 yurtOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private YurtOtomasyonuDataSet7TableAdapters.giderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikFaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suFaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazFaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetFaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}