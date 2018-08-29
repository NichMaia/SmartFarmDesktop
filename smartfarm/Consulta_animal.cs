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
    public partial class Consulta_animal : Form
    {
        public Consulta_animal()
        {
            InitializeComponent();
        }

        private void Consulta_animal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet12.tb_Animal' table. You can move, or remove it, as needed.
            this.tb_AnimalTableAdapter1.Fill(this.smartFarmDataSet12.tb_Animal);
            // TODO: This line of code loads data into the 'buscaanimaldataset.tb_Animal' table. You can move, or remove it, as needed.
            //this.tb_AnimalTableAdapter.Fill(this.buscaanimaldataset.tb_Animal);
            // TODO: This line of code loads data into the 'smartFarmDataSet7.tb_Animal' table. You can move, or remove it, as needed.
            idtxt.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtxt.Text != "")
            {
                tb_AnimalTableAdapter.FillBy(buscaanimaldataset.tb_Animal, idtxt.Text);
            }
            else if (idtxt.Text != "")
            {
                tb_AnimalTableAdapter.FillBy(buscaanimaldataset.tb_Animal,idtxt.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
