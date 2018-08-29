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
    public partial class cadastroracacs : Form
    {
        public cadastroracacs()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            tb_Raca aRaca = new tb_Raca();
            aRaca.Nome_Raca = txt_raca.Text;
            Raca.incluir(aRaca);
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_raca.Text = "";
        }

        private void txt_raca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; // bloqueia numeros
            }
        }
    }
}
