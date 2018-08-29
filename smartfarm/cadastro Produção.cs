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



    public partial class cadastro_Produção : Form
    {
        List<Tb_Produção> Listaprodução = new List<Tb_Produção>();
        public static bool adicionar = true;
        public cadastro_Produção()
        {
            InitializeComponent();
        }

        private void cadastro_Produção_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet20.Tb_Produção' table. You can move, or remove it, as needed.
           // this.tb_ProduçãoTableAdapter.Fill(this.smartFarmDataSet20.Tb_Produção);
            // TODO: This line of code loads data into the 'smartFarmDataSet19.Tb_Produção' table. You can move, or remove it, as needed.
            // this.tb_ProduçãoTableAdapter.Fill(this.smartFarmDataSet19.Tb_Produção);
            AtualizaGrid();
        }
        private string VerificaCampos()
        {
            if (txtprodução.Text == "")
                return "Produção";
            else if (txtregistro.Text == "")
                return "Registro";

            else
                return "OK";
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            String ResultadoVerificacao = VerificaCampos();
            //Se os campos estiverem todos preenchidos
            if (ResultadoVerificacao == "OK")
            {

                Tb_Produção anovaprodução = new Tb_Produção();


                //Preencher os atributos deste objeto


                anovaprodução.Registro_animal = txtregistro.Text;
                anovaprodução.Quantidade = int.Parse(txtprodução.Text);
                anovaprodução.Data = dataprodução.Value;
                

                MessageBox.Show("Salvo com sucesso");

                //Adicionar o objeto à Lista
                Listaprodução.Add(anovaprodução);

                if (adicionar)
                {

                    cadastroprodução.incluir(anovaprodução);
                    adicionar = true;
                    VoltaTelaEstadoInicial();
                }
                else
                {

                    anovaprodução.ID = int.Parse(lblid.Text);
                   cadastroprodução.alterar(anovaprodução);
                    adicionar = true;
                   

                }

            }
            else //se algum campo não estiver preenchido
            {
                MessageBox.Show("Por favor, preencha o campo " + ResultadoVerificacao + ".", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AtualizaGrid();
                
            }
            VoltaTelaEstadoInicial();
            
        }
        private void HabilitaDesabilitaCampos(bool pOpcao)
        {
            txtprodução.Enabled = pOpcao;
            txtregistro.Enabled = pOpcao;
            dataprodução.Enabled = pOpcao;

        }
        private void VoltaTelaEstadoInicial()
        {
            //Atualizar o DataGridView
            AtualizaGrid();
            HabilitaDesabilitaCampos(false);
            btnsalvar.Enabled = false;
            LimpaCampos();
           datagridprodução.ClearSelection();
            adicionar = true;
        }
        private void LimpaCampos()
        {
            txtprodução.Text = "";
            txtregistro.Text = "";
            dataprodução.Value = DateTime.Now;
            
        }
        private void AtualizaGrid()
        {
            datagridprodução.DataSource = null;
            //datagridfuncionario.DataSource = tbfuncionarioBindingSource;
            datagridprodução.DataSource = cadastroprodução.getProdução();
            datagridprodução.Refresh();
            datagridprodução.ClearSelection();
        }

       
           
    

        private void datagridprodução_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    DialogResult Validacao = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Validacao == DialogResult.Yes)
                    {

                       Tb_Produção aNovaprodução = datagridprodução.SelectedRows[0].DataBoundItem as Tb_Produção;
                        cadastroprodução.Excluir(aNovaprodução);
                        VoltaTelaEstadoInicial();
                    }
                    break;
                case 1:
                    HabilitaDesabilitaCampos(true);
                    btnsalvar.Enabled = true;
                    adicionar = false;
                    txtregistro.Focus();


                    break;
                default:
                    MessageBox.Show("Você clicou na coluna: " + datagridprodução.Columns[e.ColumnIndex].HeaderText);
                    break;
            }

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            adicionar = true;
            //habilita os campos para edição
            HabilitaDesabilitaCampos(true);

            btnsalvar.Enabled = true;
            LimpaCampos();
            txtregistro.Focus();
            datagridprodução.ClearSelection();

        }

        private void datagridprodução_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridprodução.SelectedRows.Count > 0)
            {

                HabilitaDesabilitaCampos(false);
                btnsalvar.Enabled = false;
                //Converto os valores da linha selecionada para um objeto da classe a
                Tb_Produção aNovaprodução = datagridprodução.SelectedRows[0].DataBoundItem as Tb_Produção;
                //Atribuo a cada campo na tela o valor do atributo correspondente

                if (aNovaprodução != null)
                {
                    txtprodução.Text = aNovaprodução.Quantidade.ToString();
                    txtregistro.Text = aNovaprodução.Registro_animal;
                    dataprodução.Value = aNovaprodução.Data.Value;
                    lblid.Text = aNovaprodução.ID.ToString();

                }
            }
            else
            {
                LimpaCampos();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaDesabilitaCampos(false);
        }
    }
    }

    

