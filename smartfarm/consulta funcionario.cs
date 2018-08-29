using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartfarm
{
    public partial class consulta_funcionario : Form
    {
        public consulta_funcionario()
        {
            InitializeComponent();
        }

        private void consulta_funcionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet25.tb_funcionario' table. You can move, or remove it, as needed.
           // this.tb_funcionarioTableAdapter1.Fill(this.smartFarmDataSet25.tb_funcionario);
            // TODO: This line of code loads data into the 'smartFarmDataSet24.tb_funcionario' table. You can move, or remove it, as needed.
            this.tb_funcionarioTableAdapter.Fill(this.smartFarmDataSet24.tb_funcionario);
          

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (Funcionariobox.Text != "")
            {
                tb_funcionarioTableAdapter1.FillByreg(smartFarmDataSet25.tb_funcionario, Funcionariobox.Text);
            }
        }
    }
}
