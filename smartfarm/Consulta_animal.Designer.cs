namespace smartfarm
{
    partial class Consulta_animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_animal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscaanimaldataset = new smartfarm.buscaanimaldataset();
            this.idtxt = new System.Windows.Forms.ComboBox();
            this.tbAnimalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet12 = new smartfarm.SmartFarmDataSet12();
            this.tb_AnimalTableAdapter = new smartfarm.buscaanimaldatasetTableAdapters.tb_AnimalTableAdapter();
            this.tb_AnimalTableAdapter1 = new smartfarm.SmartFarmDataSet12TableAdapters.tb_AnimalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaanimaldataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro :";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(349, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(32, 29);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAnimalDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn,
            this.filiacaoDataGridViewTextBoxColumn,
            this.classificacaoDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.boxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbAnimalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 112);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDAnimalDataGridViewTextBoxColumn
            // 
            this.iDAnimalDataGridViewTextBoxColumn.DataPropertyName = "ID_Animal";
            this.iDAnimalDataGridViewTextBoxColumn.HeaderText = "ID_Animal";
            this.iDAnimalDataGridViewTextBoxColumn.Name = "iDAnimalDataGridViewTextBoxColumn";
            this.iDAnimalDataGridViewTextBoxColumn.Visible = false;
            // 
            // racaDataGridViewTextBoxColumn
            // 
            this.racaDataGridViewTextBoxColumn.DataPropertyName = "Raca";
            this.racaDataGridViewTextBoxColumn.HeaderText = "Raça";
            this.racaDataGridViewTextBoxColumn.Name = "racaDataGridViewTextBoxColumn";
            // 
            // filiacaoDataGridViewTextBoxColumn
            // 
            this.filiacaoDataGridViewTextBoxColumn.DataPropertyName = "Filiacao";
            this.filiacaoDataGridViewTextBoxColumn.HeaderText = "Filiação";
            this.filiacaoDataGridViewTextBoxColumn.Name = "filiacaoDataGridViewTextBoxColumn";
            // 
            // classificacaoDataGridViewTextBoxColumn
            // 
            this.classificacaoDataGridViewTextBoxColumn.DataPropertyName = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.HeaderText = "Classificação";
            this.classificacaoDataGridViewTextBoxColumn.Name = "classificacaoDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // boxDataGridViewTextBoxColumn
            // 
            this.boxDataGridViewTextBoxColumn.DataPropertyName = "Box";
            this.boxDataGridViewTextBoxColumn.HeaderText = "Box";
            this.boxDataGridViewTextBoxColumn.Name = "boxDataGridViewTextBoxColumn";
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tb_Animal";
            this.tbAnimalBindingSource.DataSource = this.buscaanimaldataset;
            // 
            // buscaanimaldataset
            // 
            this.buscaanimaldataset.DataSetName = "buscaanimaldataset";
            this.buscaanimaldataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idtxt
            // 
            this.idtxt.DataSource = this.tbAnimalBindingSource1;
            this.idtxt.DisplayMember = "ID_Animal";
            this.idtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idtxt.FormattingEnabled = true;
            this.idtxt.Location = new System.Drawing.Point(129, 33);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(177, 21);
            this.idtxt.TabIndex = 4;
            this.idtxt.ValueMember = "ID_Animal";
            // 
            // tbAnimalBindingSource1
            // 
            this.tbAnimalBindingSource1.DataMember = "tb_Animal";
            this.tbAnimalBindingSource1.DataSource = this.smartFarmDataSet12;
            // 
            // smartFarmDataSet12
            // 
            this.smartFarmDataSet12.DataSetName = "SmartFarmDataSet12";
            this.smartFarmDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_AnimalTableAdapter
            // 
            this.tb_AnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tb_AnimalTableAdapter1
            // 
            this.tb_AnimalTableAdapter1.ClearBeforeFill = true;
            // 
            // Consulta_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(742, 288);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_animal";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Consulta_animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaanimaldataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox idtxt;
        private buscaanimaldataset buscaanimaldataset;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
        private buscaanimaldatasetTableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter;
        private SmartFarmDataSet12 smartFarmDataSet12;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource1;
        private SmartFarmDataSet12TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxDataGridViewTextBoxColumn;
    }
}