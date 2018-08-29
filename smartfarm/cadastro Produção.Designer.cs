namespace smartfarm
{
    partial class cadastro_Produção
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_Produção));
            this.Registro = new System.Windows.Forms.Label();
            this.txtregistro = new System.Windows.Forms.MaskedTextBox();
            this.txtprodução = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataprodução = new System.Windows.Forms.DateTimePicker();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.datagridprodução = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroanimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProduçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet20 = new smartfarm.SmartFarmDataSet20();
            this.lblid = new System.Windows.Forms.Label();
            this.tb_ProduçãoTableAdapter = new smartfarm.SmartFarmDataSet20TableAdapters.Tb_ProduçãoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprodução)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(83, 28);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(60, 16);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registro";
            // 
            // txtregistro
            // 
            this.txtregistro.Location = new System.Drawing.Point(160, 25);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(154, 20);
            this.txtregistro.TabIndex = 1;
            // 
            // txtprodução
            // 
            this.txtprodução.Location = new System.Drawing.Point(160, 71);
            this.txtprodução.Name = "txtprodução";
            this.txtprodução.Size = new System.Drawing.Size(154, 20);
            this.txtprodução.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // dataprodução
            // 
            this.dataprodução.Location = new System.Drawing.Point(160, 113);
            this.dataprodução.Name = "dataprodução";
            this.dataprodução.Size = new System.Drawing.Size(250, 20);
            this.dataprodução.TabIndex = 5;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.FlatAppearance.BorderSize = 0;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(184, 171);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(38, 38);
            this.btnsalvar.TabIndex = 15;
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(237, 168);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 45);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.ForeColor = System.Drawing.Color.Transparent;
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.Location = new System.Drawing.Point(106, 157);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(57, 52);
            this.btnnovo.TabIndex = 22;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // datagridprodução
            // 
            this.datagridprodução.AllowUserToAddRows = false;
            this.datagridprodução.AllowUserToDeleteRows = false;
            this.datagridprodução.AllowUserToResizeColumns = false;
            this.datagridprodução.AllowUserToResizeRows = false;
            this.datagridprodução.AutoGenerateColumns = false;
            this.datagridprodução.BackgroundColor = System.Drawing.Color.White;
            this.datagridprodução.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridprodução.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar,
            this.iDDataGridViewTextBoxColumn,
            this.registroanimalDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.datagridprodução.DataSource = this.tbProduçãoBindingSource;
            this.datagridprodução.Location = new System.Drawing.Point(86, 219);
            this.datagridprodução.Name = "datagridprodução";
            this.datagridprodução.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridprodução.Size = new System.Drawing.Size(544, 91);
            this.datagridprodução.TabIndex = 23;
            this.datagridprodução.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridprodução_CellContentClick_1);
            this.datagridprodução.SelectionChanged += new System.EventHandler(this.datagridprodução_SelectionChanged);
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registroanimalDataGridViewTextBoxColumn
            // 
            this.registroanimalDataGridViewTextBoxColumn.DataPropertyName = "Registro_animal";
            this.registroanimalDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroanimalDataGridViewTextBoxColumn.Name = "registroanimalDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // tbProduçãoBindingSource
            // 
            this.tbProduçãoBindingSource.DataMember = "Tb_Produção";
            this.tbProduçãoBindingSource.DataSource = this.smartFarmDataSet20;
            // 
            // smartFarmDataSet20
            // 
            this.smartFarmDataSet20.DataSetName = "SmartFarmDataSet20";
            this.smartFarmDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(637, 219);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 24;
            this.lblid.Text = "__";
            this.lblid.Visible = false;
            // 
            // tb_ProduçãoTableAdapter
            // 
            this.tb_ProduçãoTableAdapter.ClearBeforeFill = true;
            // 
            // cadastro_Produção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(746, 309);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.datagridprodução);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dataprodução);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprodução);
            this.Controls.Add(this.txtregistro);
            this.Controls.Add(this.Registro);
            this.Name = "cadastro_Produção";
            this.Text = "cadastro_Produção";
            this.Load += new System.EventHandler(this.cadastro_Produção_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridprodução)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.MaskedTextBox txtregistro;
        private System.Windows.Forms.MaskedTextBox txtprodução;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataprodução;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView datagridprodução;
        private System.Windows.Forms.Label lblid;
        private SmartFarmDataSet20 smartFarmDataSet20;
        private System.Windows.Forms.BindingSource tbProduçãoBindingSource;
        private SmartFarmDataSet20TableAdapters.Tb_ProduçãoTableAdapter tb_ProduçãoTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroanimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}