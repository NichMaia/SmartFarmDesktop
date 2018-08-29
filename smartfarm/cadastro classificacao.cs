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
    public partial class cadastroclassificacao : Form
    {
        public cadastroclassificacao()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Txt_classificacao.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //tb_Raca aRaca = new tb_Raca();
           // tb_Classificacao aClassificacao = new tb_Classificacao();
           // aClassificacao.Nome_Classificacao = Txt_classificacao.Text;
          //  Classificacao.incluir(aClassificacao);
        
            
            
           
        }

        private void dgvclassificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
