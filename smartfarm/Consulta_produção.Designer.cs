namespace smartfarm
{
    partial class Consulta_produção
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_produção));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroanimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProduçãoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.consultaproduçãoset = new smartfarm.consultaproduçãoset();
            this.datatxt = new System.Windows.Forms.ComboBox();
            this.tbProduçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet22 = new smartfarm.SmartFarmDataSet22();
            this.tb_ProduçãoTableAdapter = new smartfarm.SmartFarmDataSet22TableAdapters.Tb_ProduçãoTableAdapter();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.tb_ProduçãoTableAdapter2 = new smartfarm.consultaproduçãosetTableAdapters.Tb_ProduçãoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.registrobox = new System.Windows.Forms.ComboBox();
            this.tbProduçãoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smartFarmDataSet26 = new smartfarm.SmartFarmDataSet26();
            this.tb_ProduçãoTableAdapter1 = new smartfarm.SmartFarmDataSet26TableAdapters.Tb_ProduçãoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaproduçãoset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet26)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data :";
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
            this.iDDataGridViewTextBoxColumn,
            this.registroanimalDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProduçãoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(120, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 132);
            this.dataGridView1.TabIndex = 5;
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
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade ";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // tbProduçãoBindingSource2
            // 
            this.tbProduçãoBindingSource2.DataMember = "Tb_Produção";
            this.tbProduçãoBindingSource2.DataSource = this.consultaproduçãoset;
            // 
            // consultaproduçãoset
            // 
            this.consultaproduçãoset.DataSetName = "consultaproduçãoset";
            this.consultaproduçãoset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datatxt
            // 
            this.datatxt.DataSource = this.tbProduçãoBindingSource;
            this.datatxt.DisplayMember = "Data";
            this.datatxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datatxt.FormattingEnabled = true;
            this.datatxt.Location = new System.Drawing.Point(138, 28);
            this.datatxt.Name = "datatxt";
            this.datatxt.Size = new System.Drawing.Size(223, 21);
            this.datatxt.TabIndex = 6;
            this.datatxt.ValueMember = "Data";
            this.datatxt.SelectedIndexChanged += new System.EventHandler(this.datatxt_SelectedIndexChanged);
            // 
            // tbProduçãoBindingSource
            // 
            this.tbProduçãoBindingSource.DataMember = "Tb_Produção";
            this.tbProduçãoBindingSource.DataSource = this.smartFarmDataSet22;
            // 
            // smartFarmDataSet22
            // 
            this.smartFarmDataSet22.DataSetName = "SmartFarmDataSet22";
            this.smartFarmDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ProduçãoTableAdapter
            // 
            this.tb_ProduçãoTableAdapter.ClearBeforeFill = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(389, 36);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(32, 29);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // tb_ProduçãoTableAdapter2
            // 
            this.tb_ProduçãoTableAdapter2.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registro :";
            // 
            // registrobox
            // 
            this.registrobox.DataSource = this.tbProduçãoBindingSource1;
            this.registrobox.DisplayMember = "Registro_animal";
            this.registrobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registrobox.FormattingEnabled = true;
            this.registrobox.Location = new System.Drawing.Point(138, 64);
            this.registrobox.Name = "registrobox";
            this.registrobox.Size = new System.Drawing.Size(223, 21);
            this.registrobox.TabIndex = 9;
            this.registrobox.ValueMember = "Registro_animal";
            // 
            // tbProduçãoBindingSource1
            // 
            this.tbProduçãoBindingSource1.DataMember = "Tb_Produção";
            this.tbProduçãoBindingSource1.DataSource = this.smartFarmDataSet26;
            // 
            // smartFarmDataSet26
            // 
            this.smartFarmDataSet26.DataSetName = "SmartFarmDataSet26";
            this.smartFarmDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ProduçãoTableAdapter1
            // 
            this.tb_ProduçãoTableAdapter1.ClearBeforeFill = true;
            // 
            // Consulta_produção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(646, 334);
            this.Controls.Add(this.registrobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.datatxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_produção";
            this.Text = "Consulta produção";
            this.Load += new System.EventHandler(this.Consulta_produção_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaproduçãoset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduçãoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFarmDataSet26)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox datatxt;
        private SmartFarmDataSet22 smartFarmDataSet22;
        private System.Windows.Forms.BindingSource tbProduçãoBindingSource;
        private SmartFarmDataSet22TableAdapters.Tb_ProduçãoTableAdapter tb_ProduçãoTableAdapter;
        private System.Windows.Forms.Button btnbuscar;
        private consultaproduçãoset consultaproduçãoset;
        private System.Windows.Forms.BindingSource tbProduçãoBindingSource2;
        private consultaproduçãosetTableAdapters.Tb_ProduçãoTableAdapter tb_ProduçãoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroanimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox registrobox;
        private SmartFarmDataSet26 smartFarmDataSet26;
        private System.Windows.Forms.BindingSource tbProduçãoBindingSource1;
        private SmartFarmDataSet26TableAdapters.Tb_ProduçãoTableAdapter tb_ProduçãoTableAdapter1;
    }
}