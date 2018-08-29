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
using System.Text.RegularExpressions;


namespace smartfarm
{
    public partial class Cadastro_Animal : Form
    {
        public static bool adicionar = true;

        List<tb_Animal> ListaAnimal = new List<tb_Animal>();

        public Cadastro_Animal()
        {
            InitializeComponent();
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
                  //  bool Encontrouanimal = false;

                    //Percorre a lista através do índice de cada elemento
                    //começando no 0 e indo até um antes da quantidade de elementos
                   // for (int i = 0; i < ListaAnimal.Count; i++)
                   // {
                        //Compara o CPF do elemento de indice "i" com o CPF digitado na tela
                     //   if (ListaAnimal[i].ID_Animal == txt_id.Text)
                     //   {
                            //Se encontrar na lista um CPF igual ao que está na tela
                            //atualiza os valores deste elemento ("i") da lista 
                            //com as informações que estão na tela neste momento
                        //    ListaAnimal[i].Box = txt_box.Text;
                          //  ListaAnimal[i].Classificacao = boxclassificacao.Text;
                          //  ListaAnimal[i].DataNasc = box_datanasci.Value;
                          //  ListaAnimal[i].Filiacao = txt_filacao.Text;
                          //  ListaAnimal[i].ID_Animal = txt_id.Text;
                          //  ListaAnimal[i].Raca = box_raca.Text;
                          //  ListaAnimal[i].Registro_animal = int.Parse(txtregistro.Text);

                          //  Encontrouanimal = true;
                      ///  }
                   // }
                    //Se o funcionario não foi encontrado na lista
                   // if (!Encontrouanimal)
                   // {
                        //Criar um objeto da classe Aluno

                        tb_Animal oNovoanimal = new tb_Animal();

                        //Preencher os atributos deste objeto
                        oNovoanimal.Box = txt_box.Text;
                        oNovoanimal.Classificacao = boxclassificacao.Text;
                        oNovoanimal.DataNasc = box_datanasci.Value;
                        oNovoanimal.Filiacao = txt_filacao.Text;
                       
                        oNovoanimal.Raca = box_raca.Text;
                        oNovoanimal.Registro_animal = txtregistro.Text;

                        MessageBox.Show("Salvo com sucesso");

                        ListaAnimal.Add(oNovoanimal);

                        if (adicionar)
                        {

                            Animal.incluir(oNovoanimal);
                            adicionar = true;
                        }

                        else
                        {
                        oNovoanimal.ID_Animal = int.Parse(lblid.Text);
                            Animal.alterar(oNovoanimal);
                            adicionar = true;
                          
                        }

                    }
                    
                
                else //se algum campo não estiver preenchido
                {
                    MessageBox.Show("Por favor, preencha o campo " + ResultadoVerificacao + ".", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AtualizaGrid();
                }
               
            }
            VoltaTelaEstadoInicial();
        }
        private void HabilitaDesabilitaCampos(bool pOpcao)
        {
            txt_box.Enabled = pOpcao;
          boxclassificacao.Enabled = pOpcao;
            txt_filacao.Enabled = pOpcao;
           box_raca.Enabled = pOpcao;
            box_datanasci.Enabled = pOpcao;
        
            txtregistro.Enabled = pOpcao;
         



        }

        private void VoltaTelaEstadoInicial()
        {
            AtualizaGrid();
            HabilitaDesabilitaCampos(false);
            btn_salvar.Enabled = false;
            LimpaCampos();
            datagridanimal.ClearSelection();
        }
        private void LimpaCampos()
        {
           

            box_datanasci.Value = System.DateTime.Now;
            box_raca.SelectedIndex = -1;
            boxclassificacao.SelectedIndex = -1;
          
           txt_filacao.Text = "";
            txt_box.Text = "";
            txtregistro.Text = "";
            
        }
        private void AtualizaGrid()
        {
            datagridanimal.DataSource = null;
            datagridanimal.DataSource = Animal.getAnimal();
            datagridanimal.Refresh();
            datagridanimal.ClearSelection();
        }
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaDesabilitaCampos(false);
           

        }
        private string VerificaCampos()
        {
            if (txt_filacao.Text == "")
                return "Filiação";
            
            else if (txt_box.Text == "")
                return "Box";
            else if (boxclassificacao.Text == "")
                return "Classificação";
            else if (box_raca.Text == "")
                return "Raça";
            else if (txtregistro.Text == "")
                return "Registro";
            else
                return "OK";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet21.tb_Animal' table. You can move, or remove it, as needed.
           // this.tb_AnimalTableAdapter3.Fill(this.smartFarmDataSet21.tb_Animal);

            AtualizaGrid();
        }

      

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;// bloqueia espaços  e letras

            if (!(char.IsDigit(e.KeyChar)))            
                e.Handled = true;// bloqueia caracteres especiais
            
        }

        private void txt_datanascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_filacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; // bloqueia numeros
            }
        }

        private void txt_classificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  if (!(char.IsDigit(e.KeyChar)))
          //  {
          //      e.Handled = true;// bloqueia caracteres especiais
         //   }
         //   if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
         //   {
         //       e.Handled = true; // bloqueia numeros
           // }
        }

        private void txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;// bloqueia caracteres especiais
            }
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;// bloqueia espaços  e letras
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void boxclassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datagridanimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    DialogResult Validacao = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Validacao == DialogResult.Yes)
                    {
                        tb_Animal oanimaltemp = datagridanimal.SelectedRows[0].DataBoundItem as tb_Animal;
                        Animal.Excluir(oanimaltemp);
                        VoltaTelaEstadoInicial();
                    }
                    break;
                case 1:
                    HabilitaDesabilitaCampos(true);
                    btn_salvar.Enabled = true;
                   
                    break;
                default:
                    MessageBox.Show("Você clicou na coluna: " + datagridanimal.Columns[e.ColumnIndex].HeaderText);
                    break;
            }
        }
        private void datagridanimal_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridanimal.SelectedRows.Count > 0)
            {

                HabilitaDesabilitaCampos(false);
                btn_salvar.Enabled = false;
                //Converto os valores da linha selecionada para um objeto da classe a
                tb_Animal oanimal = datagridanimal.SelectedRows[0].DataBoundItem as tb_Animal;
                //Atribuo a cada campo na tela o valor do atributo correspondente

                if (oanimal != null)
                {
                   
                    
                    txt_filacao.Text = oanimal.Filiacao;
                    txt_box.Text = oanimal.Box;
                    box_datanasci.Value = oanimal.DataNasc.Value;
                    box_raca.SelectedItem = oanimal.Raca;
                    boxclassificacao.SelectedItem = oanimal.Classificacao;
                   
            }
            else
            {
                LimpaCampos();
            }

        
           
    }


}

        private void Novo_Click(object sender, EventArgs e)
        {
            adicionar = true;
            //habilita os campos para edição
            HabilitaDesabilitaCampos(true);

            btn_salvar.Enabled = true;
            LimpaCampos();
          
            datagridanimal.ClearSelection();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

