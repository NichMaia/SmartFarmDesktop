namespace smartfarm
{
    partial class consulta_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_funcionario));
            this.Funcionariobox = new System.Windows.Forms.ComboBox();
            this.tbfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet24 = new smartfarm.SmartFarmDataSet24();
            this.Funcionario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfuncionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet25 = new smartfarm.SmartFarmDataSet25();
            this.tb_funcionariooTableAdapter1 = new smartfarm.SmartFarmDataSet3TableAdapters.tb_funcionariooTableAdapter();
            this.tb_funcionarioTableAdapter = new smartfarm.SmartFarmDataSet24TableAdapters.tb_funcionarioTableAdapter();
            this.tb_funcionarioTableAdapter1 = new smartfarm.SmartFarmDataSet25TableAdapters.tb_funcionarioTableAdapter();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet25)).BeginInit();
            this.SuspendLayout();
            // 
            // Funcionariobox
            // 
            this.Funcionariobox.DataSource = this.tbfuncionarioBindingSource;
            this.Funcionariobox.DisplayMember = "Registro";
            this.Funcionariobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Funcionariobox.FormattingEnabled = true;
            this.Funcionariobox.Location = new System.Drawing.Point(200, 39);
            this.Funcionariobox.Name = "Funcionariobox";
            this.Funcionariobox.Size = new System.Drawing.Size(223, 21);
            this.Funcionariobox.TabIndex = 0;
            this.Funcionariobox.ValueMember = "Registro";
            // 
            // tbfuncionarioBindingSource
            // 
            this.tbfuncionarioBindingSource.DataMember = "tb_funcionario";
            this.tbfuncionarioBindingSource.DataSource = this.smartFarmDataSet24;
            // 
            // smartFarmDataSet24
            // 
            this.smartFarmDataSet24.DataSetName = "SmartFarmDataSet24";
            this.smartFarmDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSize = true;
            this.Funcionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcionario.Location = new System.Drawing.Point(23, 40);
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(161, 16);
            this.Funcionario.TabIndex = 1;
            this.Funcionario.Text = "Registro Do Funcionario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbfuncionarioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(41, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 156);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // tbfuncionarioBindingSource1
            // 
            this.tbfuncionarioBindingSource1.DataMember = "tb_funcionario";
            this.tbfuncionarioBindingSource1.DataSource = this.smartFarmDataSet25;
            // 
            // smartFarmDataSet25
            // 
            this.smartFarmDataSet25.DataSetName = "SmartFarmDataSet25";
            this.smartFarmDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_funcionariooTableAdapter1
            // 
            this.tb_funcionariooTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_funcionarioTableAdapter
            // 
            this.tb_funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tb_funcionarioTableAdapter1
            // 
            this.tb_funcionarioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(472, 40);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(32, 29);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // consulta_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(832, 338);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Funcionario);
            this.Controls.Add(this.Funcionariobox);
            this.Name = "consulta_funcionario";
            this.Text = "consulta_funcionario";
            this.Load += new System.EventHandler(this.consulta_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Funcionariobox;
        private System.Windows.Forms.Label Funcionario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SmartFarmDataSet3TableAdapters.tb_funcionariooTableAdapter tb_funcionariooTableAdapter1;
        private SmartFarmDataSet24 smartFarmDataSet24;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource;
        private SmartFarmDataSet24TableAdapters.tb_funcionarioTableAdapter tb_funcionarioTableAdapter;
        private SmartFarmDataSet25 smartFarmDataSet25;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource1;
        private SmartFarmDataSet25TableAdapters.tb_funcionarioTableAdapter tb_funcionarioTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnbuscar;
    }
}