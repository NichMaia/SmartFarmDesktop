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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroDeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //G4_Area_do_Aluno.FrmCadastroDisciplina FrmDisciplina = new G4_Area_do_Aluno.FrmCadastroDisciplina();
            //FrmDisciplina.Show();
            smartfarm.Cadastro_Animal frmCadastro_Animal = new smartfarm.Cadastro_Animal();
            frmCadastro_Animal.Show();
        }

        private void cadastroDeClassificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.cadastroclassificacao frmcadastroclassificacao = new smartfarm.cadastroclassificacao();
            frmcadastroclassificacao.Show();
        }

        private void cadastroDeCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.cadastro_cargocs frmcadastro_cargocs = new smartfarm.cadastro_cargocs();
            frmcadastro_cargocs.Show();
        }

        private void cadastroDeFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.Cadastro_Funcionario frmCadastro_Funcionario = new smartfarm.Cadastro_Funcionario();
            frmCadastro_Funcionario.Show();

        }

        private void cadastroDeRaçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.cadastroracacs frmcadastroracacs = new smartfarm.cadastroracacs();
            frmcadastroracacs.Show();
        }

        private void consultaAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.Consulta_animal frmConsulta_animal = new smartfarm.Consulta_animal();
            frmConsulta_animal.Show();
        }

        private void consultaDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.Consulta_produção frmConsulta_produção = new smartfarm.Consulta_produção();
            frmConsulta_produção.Show();
        }

        private void consultaDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.Consulta_vacinação frmConsulta_vacinação = new smartfarm.Consulta_vacinação();
            frmConsulta_vacinação.Show();
        }

        private void cadastroDeVacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.cadastro_de_vacina frmCadastro_de_vacina = new smartfarm.cadastro_de_vacina();
            frmCadastro_de_vacina.Show();
        }

        private void consultaFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.consulta_funcionario frmConsulta_Funcionario = new smartfarm.consulta_funcionario();
            frmConsulta_Funcionario.Show();
        }

        private void cadastroDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartfarm.cadastro_Produção frmCadastro_Produção = new smartfarm.cadastro_Produção();
            frmCadastro_Produção.Show();
        }
    }
}
