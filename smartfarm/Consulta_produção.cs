using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smartfarmmodel;

namespace smartfarm
{
    public partial class Consulta_produção : Form
    {
        public Consulta_produção()
        {
            InitializeComponent();
           
        }

        private void Consulta_produção_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet26.Tb_Produção' table. You can move, or remove it, as needed.
            this.tb_ProduçãoTableAdapter1.Fill(this.smartFarmDataSet26.Tb_Produção);
            // TODO: This line of code loads data into the 'consultaproduçãoset.Tb_Produção' table. You can move, or remove it, as needed.
            // this.tb_ProduçãoTableAdapter2.Fill(this.consultaproduçãoset.Tb_Produção);


            // TODO: This line of code loads data into the 'smartFarmDataSet22.Tb_Produção' table. You can move, or remove it, as needed.
            this.tb_ProduçãoTableAdapter.Fill(this.smartFarmDataSet22.Tb_Produção);
            registrobox.SelectedIndex = -1;
            datatxt.SelectedIndex = -1;
        }


      
      

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
            

            if (datatxt.Text != "")
            {
               
                tb_ProduçãoTableAdapter2.FillBydata(consultaproduçãoset.Tb_Produção, datatxt.Text);
                registrobox.SelectedIndex = -1;
                datatxt.SelectedIndex = -1;
            }
            else if (registrobox.Text != "")
            {
                
                tb_ProduçãoTableAdapter2.FillByreg(consultaproduçãoset.Tb_Produção, registrobox.Text);
                registrobox.SelectedIndex = -1;
                datatxt.SelectedIndex = -1;
            }
        }

        private void datatxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
