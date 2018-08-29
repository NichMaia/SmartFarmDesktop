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
    public partial class cadastro_cargocs : Form
    {
        public cadastro_cargocs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tb_Usuario oUsuario = new tb_Usuario();
            tb_Cargo oCargo = new tb_Cargo();
            oCargo.Cargo = txt_cargo.Text;
            Cargo.incluir(oCargo);
        }

        private void cadastro_cargocs_Load(object sender, EventArgs e)
        {

        }
    }
}
