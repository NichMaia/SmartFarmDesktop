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
using System.Data.SqlClient;
using System.Xml;


namespace smartfarm
{
    public partial class cadastro_de_vacina : Form
    {
        public static bool adicionar = true;

        List<Vacinação> Listavacina = new List<Vacinação>();
        public cadastro_de_vacina()
        {
            InitializeComponent();
        }
        private void cadastro_de_vacina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFarmDataSet27.tb_Animal' table. You can move, or remove it, as needed.
            //   this.tb_AnimalTableAdapter1.Fill(this.smartFarmDataSet27.tb_Animal);
            // TODO: This line of code loads data into the 'smartFarmDataSet18.tb_Animal' table. You can move, or remove it, as needed.
            //this.tb_AnimalTableAdapter.Fill(this.smartFarmDataSet18.tb_Animal);
            // TODO: This line of code loads data into the 'smartFarmDataSet17.Vacinação' table. You can move, or remove it, as needed.
            // this.vacinaçãoTableAdapter.Fill(this.smartFarmDataSet17.Vacinação);
            // TODO: This line of code loads data into the 'smartFarmDataSet15.tb_Animal' table. You can move, or remove it, as needed.


            carregabox();
            AtualizaGrid();
        }

        private string VerificaCampos()
        {
            if (boxid.Text == "")
                return "ID";
            else if (txtvacina.Text == "")
                return "Vacina";
            else
                return "OK";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String ResultadoVerificacao = VerificaCampos();
            //Se os campos estiverem todos preenchidos
            if (ResultadoVerificacao == "OK")
            {

                Vacinação anovavacina = new Vacinação();


                //Preencher os atributos deste objeto


                anovavacina.ID_animal = int.Parse(boxid.Text);
                anovavacina.Vacina = txtvacina.Text;
                anovavacina.Data = datavacina.Value;

                MessageBox.Show("Salvo com sucesso");

                //Adicionar o objeto à Lista
                Listavacina.Add(anovavacina);

                if (adicionar)
                {

                    Vacina.incluir(anovavacina);
                    adicionar = true;
                }

            }
        }
        private void HabilitaDesabilitaCampos(bool pOpcao)
        {
           txtvacina.Enabled = pOpcao;
            boxid.Enabled = pOpcao;
            datavacina.Enabled = pOpcao;
           



        }
        private void VoltaTelaEstadoInicial()
        {
            //Atualizar o DataGridView
            AtualizaGrid();
            HabilitaDesabilitaCampos(false);
            btnsalvar.Enabled = false;
            LimpaCampos();
            datagridvacinas.ClearSelection();
            Novo.Enabled = true;
        }
        private void LimpaCampos()
        {
            txtvacina.SelectedIndex = -1;
            boxid.SelectedIndex = -1;
            datavacina.Value = System.DateTime.Now;
           
        }
        private void AtualizaGrid()
        {
            datagridvacinas.DataSource = null;
            //datagridfuncionario.DataSource = tbfuncionarioBindingSource;
            datagridvacinas.DataSource = Vacina.getvacinas();
            datagridvacinas.Refresh();
            datagridvacinas.ClearSelection();
        }

        private void datagridvacinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    DialogResult Validacao = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Validacao == DialogResult.Yes)
                    {
                        Vacinação avacinatemp = datagridvacinas.SelectedRows[0].DataBoundItem as Vacinação;
                       Vacina.Excluir(avacinatemp);
                        VoltaTelaEstadoInicial();
                    }
                    break;
                case 1:
                    HabilitaDesabilitaCampos(true);
                    btnsalvar.Enabled = true;
                   

                   

                    break;
                default:
                    MessageBox.Show("Você clicou na coluna: " + datagridvacinas.Columns[e.ColumnIndex].HeaderText);
                    break;
            }
        }

        private void boxid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void carregabox()
        {
            boxid.Items.Clear();
                SqlConnection sql = new SqlConnection("data source=RUBENS\\RUBENS;initial catalog=SmartFarm;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = "Select Registro_animal from tb_animal";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sql;
            sql.Open();
            reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    boxid.Items.Add(reader.GetString(0));
                }
            }
            sql.Close();
            
        }
    }
    }
              
            
        
    

