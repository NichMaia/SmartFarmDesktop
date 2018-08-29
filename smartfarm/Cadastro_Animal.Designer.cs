namespace smartfarm
{
    partial class Cadastro_Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Animal));
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_filacao = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.box_datanasci = new System.Windows.Forms.DateTimePicker();
            this.box_raca = new System.Windows.Forms.ComboBox();
            this.boxclassificacao = new System.Windows.Forms.ComboBox();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.datagridanimal = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroanimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet21 = new smartfarm.SmartFarmDataSet21();
            this.smartFarmDataSet16 = new smartfarm.SmartFarmDataSet16();
            this.smartFarmDataSet11 = new smartfarm.SmartFarmDataSet11();
            this.tb_AnimalTableAdapter = new smartfarm.SmartFarmDataSet9TableAdapters.tb_AnimalTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtregistro = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.tb_AnimalTableAdapter1 = new smartfarm.SmartFarmDataSet11TableAdapters.tb_AnimalTableAdapter();
            this.tb_AnimalTableAdapter2 = new smartfarm.SmartFarmDataSet16TableAdapters.tb_AnimalTableAdapter();
            this.tb_AnimalTableAdapter3 = new smartfarm.SmartFarmDataSet21TableAdapters.tb_AnimalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridanimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(616, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "__";
            this.lblid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filiação :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Box :";
            // 
            // txt_filacao
            // 
            this.txt_filacao.Enabled = false;
            this.txt_filacao.Location = new System.Drawing.Point(173, 50);
            this.txt_filacao.Name = "txt_filacao";
            this.txt_filacao.Size = new System.Drawing.Size(299, 22);
            this.txt_filacao.TabIndex = 6;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Enabled = false;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(178, 235);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(38, 38);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(244, 232);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 45);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Classificação :";
            // 
            // box_datanasci
            // 
            this.box_datanasci.Enabled = false;
            this.box_datanasci.Location = new System.Drawing.Point(173, 106);
            this.box_datanasci.Name = "box_datanasci";
            this.box_datanasci.Size = new System.Drawing.Size(299, 22);
            this.box_datanasci.TabIndex = 14;
            this.box_datanasci.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // box_raca
            // 
            this.box_raca.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.box_raca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_raca.Enabled = false;
            this.box_raca.FormattingEnabled = true;
            this.box_raca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.box_raca.Items.AddRange(new object[] {
            "Holandesa",
            "Jersey",
            "Pardo Suiço",
            "Zebu Leiteiras",
            "Gir",
            "Guzerá",
            "Sindi",
            "Girolando"});
            this.box_raca.Location = new System.Drawing.Point(173, 19);
            this.box_raca.Name = "box_raca";
            this.box_raca.Size = new System.Drawing.Size(299, 24);
            this.box_raca.TabIndex = 15;
            // 
            // boxclassificacao
            // 
            this.boxclassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxclassificacao.Enabled = false;
            this.boxclassificacao.FormattingEnabled = true;
            this.boxclassificacao.Items.AddRange(new object[] {
            "Bezerra",
            "Novilha",
            "Vaca"});
            this.boxclassificacao.Location = new System.Drawing.Point(173, 76);
            this.boxclassificacao.Name = "boxclassificacao";
            this.boxclassificacao.Size = new System.Drawing.Size(299, 24);
            this.boxclassificacao.TabIndex = 17;
            this.boxclassificacao.SelectedIndexChanged += new System.EventHandler(this.boxclassificacao_SelectedIndexChanged);
            // 
            // txt_box
            // 
            this.txt_box.Enabled = false;
            this.txt_box.Location = new System.Drawing.Point(173, 158);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(299, 22);
            this.txt_box.TabIndex = 9;
            this.txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_box_KeyPress);
            // 
            // datagridanimal
            // 
            this.datagridanimal.AllowUserToAddRows = false;
            this.datagridanimal.AllowUserToDeleteRows = false;
            this.datagridanimal.AllowUserToResizeColumns = false;
            this.datagridanimal.AllowUserToResizeRows = false;
            this.datagridanimal.AutoGenerateColumns = false;
            this.datagridanimal.BackgroundColor = System.Drawing.Color.White;
            this.datagridanimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridanimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar,
            this.iDAnimalDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn,
            this.filiacaoDataGridViewTextBoxColumn,
            this.classificacaoDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.boxDataGridViewTextBoxColumn,
            this.registroanimalDataGridViewTextBoxColumn});
            this.datagridanimal.DataSource = this.tbAnimalBindingSource;
            this.datagridanimal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridanimal.Location = new System.Drawing.Point(44, 283);
            this.datagridanimal.Name = "datagridanimal";
            this.datagridanimal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridanimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridanimal.Size = new System.Drawing.Size(622, 150);
            this.datagridanimal.TabIndex = 18;
            this.datagridanimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridanimal_CellContentClick);
            this.datagridanimal.SelectionChanged += new System.EventHandler(this.datagridanimal_SelectionChanged);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
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
            this.racaDataGridViewTextBoxColumn.HeaderText = "Raca";
            this.racaDataGridViewTextBoxColumn.Name = "racaDataGridViewTextBoxColumn";
            // 
            // filiacaoDataGridViewTextBoxColumn
            // 
            this.filiacaoDataGridViewTextBoxColumn.DataPropertyName = "Filiacao";
            this.filiacaoDataGridViewTextBoxColumn.HeaderText = "Filiacao";
            this.filiacaoDataGridViewTextBoxColumn.Name = "filiacaoDataGridViewTextBoxColumn";
            // 
            // classificacaoDataGridViewTextBoxColumn
            // 
            this.classificacaoDataGridViewTextBoxColumn.DataPropertyName = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.HeaderText = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.Name = "classificacaoDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // boxDataGridViewTextBoxColumn
            // 
            this.boxDataGridViewTextBoxColumn.DataPropertyName = "Box";
            this.boxDataGridViewTextBoxColumn.HeaderText = "Box";
            this.boxDataGridViewTextBoxColumn.Name = "boxDataGridViewTextBoxColumn";
            // 
            // registroanimalDataGridViewTextBoxColumn
            // 
            this.registroanimalDataGridViewTextBoxColumn.DataPropertyName = "Registro_animal";
            this.registroanimalDataGridViewTextBoxColumn.HeaderText = "Registro_animal";
            this.registroanimalDataGridViewTextBoxColumn.Name = "registroanimalDataGridViewTextBoxColumn";
            // 
            // tbAnimalBindingSource
            // 
            this.tbAnimalBindingSource.DataMember = "tb_Animal";
            this.tbAnimalBindingSource.DataSource = this.smartFarmDataSet21;
            // 
            // smartFarmDataSet21
            // 
            this.smartFarmDataSet21.DataSetName = "SmartFarmDataSet21";
            this.smartFarmDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartFarmDataSet16
            // 
            this.smartFarmDataSet16.DataSetName = "SmartFarmDataSet16";
            this.smartFarmDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartFarmDataSet11
            // 
            this.smartFarmDataSet11.DataSetName = "SmartFarmDataSet11";
            this.smartFarmDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_AnimalTableAdapter
            // 
            this.tb_AnimalTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtregistro);
            this.groupBox1.Controls.Add(this.Registro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.box_datanasci);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boxclassificacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.box_raca);
            this.groupBox1.Controls.Add(this.txt_box);
            this.groupBox1.Controls.Add(this.txt_filacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 204);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Animal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtregistro
            // 
            this.txtregistro.Enabled = false;
            this.txtregistro.Location = new System.Drawing.Point(173, 132);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(299, 22);
            this.txtregistro.TabIndex = 19;
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(60, 135);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(60, 16);
            this.Registro.TabIndex = 18;
            this.Registro.Text = "Registro";
            // 
            // Novo
            // 
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.ForeColor = System.Drawing.Color.Transparent;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.Location = new System.Drawing.Point(80, 222);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 55);
            this.Novo.TabIndex = 20;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // tb_AnimalTableAdapter1
            // 
            this.tb_AnimalTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_AnimalTableAdapter2
            // 
            this.tb_AnimalTableAdapter2.ClearBeforeFill = true;
            // 
            // tb_AnimalTableAdapter3
            // 
            this.tb_AnimalTableAdapter3.ClearBeforeFill = true;
            // 
            // Cadastro_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(710, 493);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.datagridanimal);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Name = "Cadastro_Animal";
            this.Text = "Cadastro de Animal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridanimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_filacao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker box_datanasci;
        private System.Windows.Forms.ComboBox box_raca;
        private System.Windows.Forms.ComboBox boxclassificacao;
        private System.Windows.Forms.TextBox txt_box;
        private System.Windows.Forms.DataGridView datagridanimal;
        private SmartFarmDataSet9TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Novo;
        private SmartFarmDataSet11 smartFarmDataSet11;
        private SmartFarmDataSet11TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter1;
        private System.Windows.Forms.TextBox txtregistro;
        private System.Windows.Forms.Label Registro;
        private SmartFarmDataSet16 smartFarmDataSet16;
        private SmartFarmDataSet16TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter2;
        private SmartFarmDataSet21 smartFarmDataSet21;
        private System.Windows.Forms.BindingSource tbAnimalBindingSource;
        private SmartFarmDataSet21TableAdapters.tb_AnimalTableAdapter tb_AnimalTableAdapter3;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroanimalDataGridViewTextBoxColumn;
    }
}

