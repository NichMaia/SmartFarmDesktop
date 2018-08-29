namespace smartfarm
{
    partial class Cadastro_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Funcionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.box_cargo = new System.Windows.Forms.ComboBox();
            this.tbCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet1 = new smartfarm.SmartFarmDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.box_datanasci = new System.Windows.Forms.DateTimePicker();
            this.datagridfuncionario = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfuncionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet10 = new smartfarm.SmartFarmDataSet10();
            this.tbfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet8 = new smartfarm.SmartFarmDataSet8();
            this.tbfuncionariooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet = new smartfarm.SmartFarmDataSet();
            this.tb_funcionariooTableAdapter = new smartfarm.SmartFarmDataSetTableAdapters.tb_funcionariooTableAdapter();
            this.tb_CargoTableAdapter = new smartfarm.SmartFarmDataSet1TableAdapters.tb_CargoTableAdapter();
            this.tb_funcionarioTableAdapter = new smartfarm.SmartFarmDataSet8TableAdapters.tb_funcionarioTableAdapter();
            this.btnnovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_funcionarioTableAdapter1 = new smartfarm.SmartFarmDataSet10TableAdapters.tb_funcionarioTableAdapter();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridfuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionariooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RG :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cpf :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone :";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(151, 22);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(189, 22);
            this.txt_nome.TabIndex = 7;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.FlatAppearance.BorderSize = 0;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(136, 288);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(38, 38);
            this.btnsalvar.TabIndex = 14;
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(196, 285);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 45);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // box_cargo
            // 
            this.box_cargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.box_cargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbCargoBindingSource, "Cargo", true));
            this.box_cargo.Enabled = false;
            this.box_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.box_cargo.FormattingEnabled = true;
            this.box_cargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.box_cargo.Items.AddRange(new object[] {
            "Veterinario",
            "Retireiro",
            "Aux. Ordenha"});
            this.box_cargo.Location = new System.Drawing.Point(151, 141);
            this.box_cargo.Name = "box_cargo";
            this.box_cargo.Size = new System.Drawing.Size(189, 21);
            this.box_cargo.TabIndex = 16;
            this.box_cargo.Tag = "";
            this.box_cargo.Text = "[Selecione]";
            this.box_cargo.SelectedIndexChanged += new System.EventHandler(this.box_cargo_SelectedIndexChanged);
            // 
            // tbCargoBindingSource
            // 
            this.tbCargoBindingSource.DataMember = "tb_Cargo";
            this.tbCargoBindingSource.DataSource = this.smartFarmDataSet1;
            // 
            // smartFarmDataSet1
            // 
            this.smartFarmDataSet1.DataSetName = "SmartFarmDataSet1";
            this.smartFarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Registro :";
            // 
            // txt_registro
            // 
            this.txt_registro.Enabled = false;
            this.txt_registro.Location = new System.Drawing.Point(151, 204);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(189, 22);
            this.txt_registro.TabIndex = 18;
            this.txt_registro.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txt_registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // box_datanasci
            // 
            this.box_datanasci.Enabled = false;
            this.box_datanasci.Location = new System.Drawing.Point(151, 115);
            this.box_datanasci.Name = "box_datanasci";
            this.box_datanasci.Size = new System.Drawing.Size(269, 22);
            this.box_datanasci.TabIndex = 19;
            // 
            // datagridfuncionario
            // 
            this.datagridfuncionario.AllowUserToAddRows = false;
            this.datagridfuncionario.AllowUserToDeleteRows = false;
            this.datagridfuncionario.AllowUserToResizeColumns = false;
            this.datagridfuncionario.AllowUserToResizeRows = false;
            this.datagridfuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridfuncionario.AutoGenerateColumns = false;
            this.datagridfuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridfuncionario.BackgroundColor = System.Drawing.Color.White;
            this.datagridfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnExcluir,
            this.Editar,
            this.ID,
            this.nomeDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn});
            this.datagridfuncionario.DataSource = this.tbfuncionarioBindingSource1;
            this.datagridfuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridfuncionario.Location = new System.Drawing.Point(31, 335);
            this.datagridfuncionario.MultiSelect = false;
            this.datagridfuncionario.Name = "datagridfuncionario";
            this.datagridfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridfuncionario.Size = new System.Drawing.Size(503, 137);
            this.datagridfuncionario.TabIndex = 20;
            this.datagridfuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridfuncionario_CellContentClick);
            this.datagridfuncionario.SelectionChanged += new System.EventHandler(this.datagridfuncionario_SelectionChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            this.btnExcluir.Width = 63;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.Width = 60;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.Width = 71;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 74;
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            this.dataNascDataGridViewTextBoxColumn.Width = 80;
            // 
            // tbfuncionarioBindingSource1
            // 
            this.tbfuncionarioBindingSource1.DataMember = "tb_funcionario";
            this.tbfuncionarioBindingSource1.DataSource = this.smartFarmDataSet10;
            // 
            // smartFarmDataSet10
            // 
            this.smartFarmDataSet10.DataSetName = "SmartFarmDataSet10";
            this.smartFarmDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfuncionarioBindingSource
            // 
            this.tbfuncionarioBindingSource.DataMember = "tb_funcionario";
            this.tbfuncionarioBindingSource.DataSource = this.smartFarmDataSet8;
            // 
            // smartFarmDataSet8
            // 
            this.smartFarmDataSet8.DataSetName = "SmartFarmDataSet8";
            this.smartFarmDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfuncionariooBindingSource
            // 
            this.tbfuncionariooBindingSource.DataMember = "tb_funcionarioo";
            this.tbfuncionariooBindingSource.DataSource = this.smartFarmDataSet;
            // 
            // smartFarmDataSet
            // 
            this.smartFarmDataSet.DataSetName = "SmartFarmDataSet";
            this.smartFarmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_funcionariooTableAdapter
            // 
            this.tb_funcionariooTableAdapter.ClearBeforeFill = true;
            // 
            // tb_CargoTableAdapter
            // 
            this.tb_CargoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_funcionarioTableAdapter
            // 
            this.tb_funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnnovo
            // 
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.ForeColor = System.Drawing.Color.Transparent;
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.Location = new System.Drawing.Point(49, 272);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 57);
            this.btnnovo.TabIndex = 21;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rg);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_registro);
            this.groupBox1.Controls.Add(this.box_datanasci);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.box_cargo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 245);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(153, 59);
            this.txt_rg.Mask = "00.000.000-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 22);
            this.txt_rg.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 25;
            this.lblID.Visible = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(151, 172);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(86, 20);
            this.txt_telefone.TabIndex = 23;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(151, 85);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 22);
            this.txt_cpf.TabIndex = 23;
            // 
            // tb_funcionarioTableAdapter1
            // 
            this.tb_funcionarioTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(681, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 13);
            this.lbl_ID.TabIndex = 23;
            this.lbl_ID.Text = "___";
            // 
            // Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 484);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.datagridfuncionario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnsalvar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Funcionário";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridfuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionariooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.DateTimePicker box_datanasci;
        private System.Windows.Forms.DataGridView datagridfuncionario;
        private SmartFarmDataSet smartFarmDataSet;
        private System.Windows.Forms.BindingSource tbfuncionariooBindingSource;
        private SmartFarmDataSetTableAdapters.tb_funcionariooTableAdapter tb_funcionariooTableAdapter;
        private SmartFarmDataSet1 smartFarmDataSet1;
        private System.Windows.Forms.BindingSource tbCargoBindingSource;
        private SmartFarmDataSet1TableAdapters.tb_CargoTableAdapter tb_CargoTableAdapter;
        private SmartFarmDataSet8 smartFarmDataSet8;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource;
        private SmartFarmDataSet8TableAdapters.tb_funcionarioTableAdapter tb_funcionarioTableAdapter;
        protected System.Windows.Forms.ComboBox box_cargo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label lblID;
        private SmartFarmDataSet10 smartFarmDataSet10;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource1;
        private SmartFarmDataSet10TableAdapters.tb_funcionarioTableAdapter tb_funcionarioTableAdapter1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
    }
}