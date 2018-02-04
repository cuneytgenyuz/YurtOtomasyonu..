namespace YurtProjesi
{
    partial class frmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet2 = new YurtProjesi.YurtOtomasyonuDataSet2();
            this.borclarTableAdapter = new YurtProjesi.YurtOtomasyonuDataSet2TableAdapters.borclarTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdenenAy = new System.Windows.Forms.TextBox();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Id :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // txtAdı
            // 
            this.txtAdı.Enabled = false;
            this.txtAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdı.Location = new System.Drawing.Point(152, 227);
            this.txtAdı.Multiline = true;
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(166, 24);
            this.txtAdı.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(152, 259);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(166, 24);
            this.txtSoyad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(167, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ödeme Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ögrenciIdDataGridViewTextBoxColumn,
            this.ögrenciAdDataGridViewTextBoxColumn,
            this.ögrenciSoyadDataGridViewTextBoxColumn,
            this.ögrenciBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 176);
            this.dataGridView1.TabIndex = 8;
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
            // ögrenciBorcDataGridViewTextBoxColumn
            // 
            this.ögrenciBorcDataGridViewTextBoxColumn.DataPropertyName = "ögrenciBorc";
            this.ögrenciBorcDataGridViewTextBoxColumn.HeaderText = "ögrenciBorc";
            this.ögrenciBorcDataGridViewTextBoxColumn.Name = "ögrenciBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonuDataSet2;
            // 
            // yurtOtomasyonuDataSet2
            // 
            this.yurtOtomasyonuDataSet2.DataSetName = "YurtOtomasyonuDataSet2";
            this.yurtOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(70, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödenen :";
            // 
            // txtOdenen
            // 
            this.txtOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(152, 289);
            this.txtOdenen.Multiline = true;
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(166, 24);
            this.txtOdenen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kalaln Borç :";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Enabled = false;
            this.txtKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanBorc.Location = new System.Drawing.Point(152, 319);
            this.txtKalanBorc.Multiline = true;
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(166, 24);
            this.txtKalanBorc.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödenen Ay :";
            // 
            // txtOdenenAy
            // 
            this.txtOdenenAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenenAy.Location = new System.Drawing.Point(152, 349);
            this.txtOdenenAy.Multiline = true;
            this.txtOdenenAy.Name = "txtOdenenAy";
            this.txtOdenenAy.Size = new System.Drawing.Size(166, 24);
            this.txtOdenenAy.TabIndex = 6;
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Enabled = false;
            this.txtOgrenciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciId.Location = new System.Drawing.Point(152, 198);
            this.txtOgrenciId.Multiline = true;
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(166, 24);
            this.txtOgrenciId.TabIndex = 2;
            this.txtOgrenciId.Visible = false;
            // 
            // frmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOdenenAy);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.frmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.borclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdenenAy;
        private System.Windows.Forms.TextBox txtOgrenciId;
    }
}