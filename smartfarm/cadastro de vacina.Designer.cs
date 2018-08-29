namespace smartfarm
{
    partial class cadastro_de_vacina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_de_vacina));
            this.Registro = new System.Windows.Forms.Label();
            this.boxid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvacina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datavacina = new System.Windows.Forms.DateTimePicker();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.datagridvacinas = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vacinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacinaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet17 = new smartfarm.SmartFarmDataSet17();
            this.Novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.vacinaçãoTableAdapter = new smartfarm.SmartFarmDataSet17TableAdapters.VacinaçãoTableAdapter();
            this.smartFarmDataSet18 = new smartfarm.SmartFarmDataSet18();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_AnimalTableAdapter = new smartfarm.SmartFarmDataSet18TableAdapters.tb_AnimalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvacinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(75, 24);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(68, 16);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registro :";
            // 
            // boxid
            // 
            this.boxid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxid.FormattingEnabled = true;
            this.boxid.Location = new System.Drawing.Point(153, 24);
            this.boxid.Name = "boxid";
            this.boxid.Size = new System.Drawing.Size(232, 21);
            this.boxid.TabIndex = 1;
            this.boxid.SelectedIndexChanged += new System.EventHandler(this.boxid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vacina :";
            // 
            // txtvacina
            // 
            this.txtvacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtvacina.FormattingEnabled = true;
            this.txtvacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtvacina.Location = new System.Drawing.Point(153, 56);
            this.txtvacina.Name = "txtvacina";
            this.txtvacina.Size = new System.Drawing.Size(232, 21);
            this.txtvacina.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Vacinação:";
            // 
            // datavacina
            // 
            this.datavacina.Location = new System.Drawing.Point(153, 92);
            this.datavacina.Name = "datavacina";
            this.datavacina.Size = new System.Drawing.Size(232, 20);
            this.datavacina.TabIndex = 5;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.FlatAppearance.BorderSize = 0;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(149, 138);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(40, 45);
            this.btnsalvar.TabIndex = 18;
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridvacinas
            // 
            this.datagridvacinas.AllowUserToAddRows = false;
            this.datagridvacinas.AllowUserToDeleteRows = false;
            this.datagridvacinas.AllowUserToResizeColumns = false;
            this.datagridvacinas.AllowUserToResizeRows = false;
            this.datagridvacinas.AutoGenerateColumns = false;
            this.datagridvacinas.BackgroundColor = System.Drawing.Color.White;
            this.datagridvacinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridvacinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar,
            this.vacinaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn});
            this.datagridvacinas.DataSource = this.vacinaçãoBindingSource;
            this.datagridvacinas.Location = new System.Drawing.Point(24, 201);
            this.datagridvacinas.Name = "datagridvacinas";
            this.datagridvacinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridvacinas.Size = new System.Drawing.Size(545, 150);
            this.datagridvacinas.TabIndex = 19;
            this.datagridvacinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridvacinas_CellContentClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // vacinaDataGridViewTextBoxColumn
            // 
            this.vacinaDataGridViewTextBoxColumn.DataPropertyName = "Vacina";
            this.vacinaDataGridViewTextBoxColumn.HeaderText = "Vacina";
            this.vacinaDataGridViewTextBoxColumn.Name = "vacinaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            // 
            // vacinaçãoBindingSource
            // 
            this.vacinaçãoBindingSource.DataMember = "Vacinação";
            this.vacinaçãoBindingSource.DataSource = this.smartFarmDataSet17;
            // 
            // smartFarmDataSet17
            // 
            this.smartFarmDataSet17.DataSetName = "SmartFarmDataSet17";
            this.smartFarmDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Novo
            // 
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.ForeColor = System.Drawing.Color.Transparent;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.Location = new System.Drawing.Point(57, 132);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(56, 51);
            this.Novo.TabIndex = 22;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(213, 138);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 51);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // vacinaçãoTableAdapter
            // 
            this.vacinaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // smartFarmDataSet18
            // 
            this.smartFarmDataSet18.DataSetName = "SmartFarmDataSet18";
            this.smartFarmDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tb_Animal";
            this.tbAnimalBindingSource.DataSource = this.smartFarmDataSet18;
            // 
            // tb_AnimalTableAdapter
            // 
            this.tb_AnimalTableAdapter.ClearBeforeFill = true;
            // 
            // cadastro_de_vacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(591, 363);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.datagridvacinas);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.datavacina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvacina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxid);
            this.Controls.Add(this.Registro);
            this.Name = "cadastro_de_vacina";
            this.Text = "cadastro_de_vacina";
            this.Load += new System.EventHandler(this.cadastro_de_vacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridvacinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.ComboBox boxid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtvacina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datavacina;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView datagridvacinas;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button btn_cancelar;
        private SmartFarmDataSet17 smartFarmDataSet17;
        private System.Windows.Forms.BindingSource vacinaçãoBindingSource;
        private SmartFarmDataSet17TableAdapters.VacinaçãoTableAdapter vacinaçãoTableAdapter;
        private SmartFarmDataSet18 smartFarmDataSet18;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
        private SmartFarmDataSet18TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
    }
}