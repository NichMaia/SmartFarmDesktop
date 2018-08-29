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


    public partial class Cadastro_Funcionario : Form
         
    {
        public static bool adicionar = true;
        List<tb_funcionario> ListaFuncionario = new List<tb_funcionario>();

        public Cadastro_Funcionario()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string VerificaCampos()
        {
            if (txt_nome.Text == "")
                return "nome";
            else if (txt_rg.Text == "")
                return "rg";
            else if (txt_registro.Text == "")
                return "registro";
            else if (txt_cpf.Text == "   ,   ,   -")
                return "CPF";
            else if (txt_telefone.Text == "")
                return "telefone";
            else
                return "OK";
        }

        private void button1_Click(object sender, EventArgs e)

        {

            {//Verifica se os campos estão todos preenchidos
                String ResultadoVerificacao = VerificaCampos();
                //Se os campos estiverem todos preenchidos
                if (ResultadoVerificacao == "OK")
                {
                    //Variável para identificar se algum funcionario foi encontrado na lista
                    //com o CPF que está na tela
                   // bool EncontrouFuncionario = false;

                    //Percorre a lista através do índice de cada elemento
                    //começando no 0 e indo até um antes da quantidade de elementos
                   // for (int i = 0; i < ListaFuncionario.Count; i++)
                   // {
                        //Compara o CPF do elemento de indice "i" com o CPF digitado na tela
                       // if (ListaFuncionario[i].cpf == txt_cpf.Text)
                      //  {
                            //Se encontrar na lista um CPF igual ao que está na tela
                            //atualiza os valores deste elemento ("i") da lista 
                            //com as informações que estão na tela neste momento

                           // ListaFuncionario[i].DataNasc = box_datanasci.Value;
                           // ListaFuncionario[i].Registro = txt_registro.Text;
                           // ListaFuncionario[i].Rg = txt_rg.Text;
                           // ListaFuncionario[i].Nome = txt_nome.Text;
                           // ListaFuncionario[i].Cargo = box_cargo.Text;
                          //  ListaFuncionario[i].Telefone = txt_telefone.Text;


                          //  EncontrouFuncionario = true;
                      //  }
                  //  }
                    //Se o funcionario não foi encontrado na lista
                   // if (!EncontrouFuncionario)
                   // {
                        //Criar um objeto da classe Aluno

                        tb_funcionario oNovofuncionario = new tb_funcionario();

                        //Preencher os atributos deste objeto

                        oNovofuncionario.DataNasc = box_datanasci.Value;
                        oNovofuncionario.Rg = txt_rg.Text;
                        oNovofuncionario.cpf = txt_cpf.Text;
                        oNovofuncionario.Nome = txt_nome.Text;
                        oNovofuncionario.Cargo = box_cargo.Text;
                        oNovofuncionario.Telefone = txt_telefone.Text;
                        oNovofuncionario.Registro = txt_registro.Text;
                        MessageBox.Show("Salvo com sucesso");

                        //Adicionar o objeto à Lista
                        ListaFuncionario.Add(oNovofuncionario);

                        if (adicionar)
                        {

                            Funcionario.incluir(oNovofuncionario);
                            adicionar = true;
                            VoltaTelaEstadoInicial();
                        }

                        else
                        {
                            oNovofuncionario.ID = int.Parse(lbl_ID.Text);
                            Funcionario.alterar(oNovofuncionario);
                            adicionar = true;

                        }

                    }

                //Volta a tela para o estado inicial

                else //se algum campo não estiver preenchido
                {
                    MessageBox.Show("Por favor, preencha o campo " + ResultadoVerificacao + ".", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AtualizaGrid();
                }

                VoltaTelaEstadoInicial();
            }
          

        }
        private void HabilitaDesabilitaCampos(bool pOpcao)
        {
            txt_cpf.Enabled = pOpcao;
            txt_nome.Enabled = pOpcao;
            txt_registro.Enabled = pOpcao;
            box_cargo.Enabled = pOpcao;
            box_datanasci.Enabled = pOpcao;
            txt_rg.Enabled = pOpcao;
            txt_telefone.Enabled = pOpcao;
           

           
        }

     

        private void VoltaTelaEstadoInicial()
        {
            //Atualizar o DataGridView
            AtualizaGrid();
            HabilitaDesabilitaCampos(false);
            btnsalvar.Enabled = false;
            LimpaCampos();
            datagridfuncionario.ClearSelection();
            adicionar = true;
        }
        private void LimpaCampos()
        {
            txt_nome.Text = "";
            lbl_ID.Text = "___";
            box_datanasci.Value = System.DateTime.Now;
            box_cargo.SelectedIndex = -1;
            txt_rg.Text = "";
            txt_telefone.Text = "";
            txt_cpf.Text = "";
            txt_registro.Text = "";
        }
        private void AtualizaGrid()
        {
            datagridfuncionario.DataSource = null;
            //datagridfuncionario.DataSource = tbfuncionarioBindingSource;
            datagridfuncionario.DataSource = Funcionario.getFuncionarios();
            datagridfuncionario.Refresh();
            datagridfuncionario.ClearSelection();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaDesabilitaCampos(false);
        }

        private void txt_rg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet10.tb_funcionario' table. You can move, or remove it, as needed.
           // this.tb_funcionarioTableAdapter1.Fill(this.smartFarmDataSet10.tb_funcionario);
            // TODO: This line of code loads data into the 'smartFarmDataSet8.tb_funcionario' table. You can move, or remove it, as needed.
            //this.tb_funcionarioTableAdapter.Fill(this.smartFarmDataSet8.tb_funcionario);
            // TODO: This line of code loads data into the 'smartFarmDataSet1.tb_Cargo' table. You can move, or remove it, as needed.
          //  this.tb_CargoTableAdapter.Fill(this.smartFarmDataSet1.tb_Cargo);
            // TODO: This line of code loads data into the 'smartFarmDataSet.tb_funcionarioo' table. You can move, or remove it, as needed.
            //this.tb_funcionariooTableAdapter.Fill(this.smartFarmDataSet.tb_funcionario);

            AtualizaGrid();

        }

        private void box_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true; // bloqueia letras e espaço
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
            // bloqueia letras e espaço
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
        }


        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true; // bloqueia letras e espaço
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true; // bloqueia letras e espaço
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; // bloqueia numeros
            }
        }

        private void txt_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
        }

        private void txt_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_CargoTableAdapter.FillBy(this.smartFarmDataSet1.tb_Cargo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void datagridfuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    DialogResult Validacao = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Validacao == DialogResult.Yes)
                    {
                        tb_funcionario ofuncionariotemp = datagridfuncionario.SelectedRows[0].DataBoundItem as tb_funcionario;
                        Funcionario.Excluir(ofuncionariotemp);
                        VoltaTelaEstadoInicial();
                    }
                    break;
                case 1:
                    HabilitaDesabilitaCampos(true);
                    btnsalvar.Enabled = true;
                    adicionar = false;
                   
                    txt_nome.Focus();
                    
                    break;
                default:
                    MessageBox.Show("Você clicou na coluna: " + datagridfuncionario.Columns[e.ColumnIndex].HeaderText);
                    break;
            }
        }
    

        private void datagridfuncionario_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridfuncionario.SelectedRows.Count > 0)
            {

                HabilitaDesabilitaCampos(false);
                btnsalvar.Enabled = false;
                //Converto os valores da linha selecionada para um objeto da classe a
                tb_funcionario ofuncionarioTemp = datagridfuncionario.SelectedRows[0].DataBoundItem as tb_funcionario;
                //Atribuo a cada campo na tela o valor do atributo correspondente

                if (ofuncionarioTemp != null)
                {
                    lbl_ID.Text = ofuncionarioTemp.ID.ToString();
                    txt_cpf.Text = ofuncionarioTemp.cpf;
                    txt_registro.Text = ofuncionarioTemp.Registro;
                    txt_rg.Text = ofuncionarioTemp.Rg;
                    txt_nome.Text = ofuncionarioTemp.Nome;
                    txt_telefone.Text = ofuncionarioTemp.Telefone;
                    box_cargo.Text = ofuncionarioTemp.Cargo;
                    box_datanasci.Value = ofuncionarioTemp.DataNasc.Value;
                }
            }
            else
            {
                LimpaCampos();
            }

        }
        
           

    private void Novo_Click(object sender, EventArgs e)
        {

            adicionar = true;
            //habilita os campos para edição
            HabilitaDesabilitaCampos(true);

            btnsalvar.Enabled = true;
            LimpaCampos();
            txt_nome.Focus();
            datagridfuncionario.ClearSelection();

        }
    }
}
    



    

