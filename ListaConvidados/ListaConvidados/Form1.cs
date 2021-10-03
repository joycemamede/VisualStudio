using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ListaConvidados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "convidado";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
            dgConvidado.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 8);
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                // 1. Open the dB connection
                realizaConexacoBD.Open();
                Console.WriteLine("conexao aberta");

                // 2. Make a query for the data we'd like to show in our table
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM convidado";
                MySqlDataReader reader = comandoMySql.ExecuteReader();
                Console.WriteLine("comando executado");

                Console.WriteLine("reader.hasRows = " + reader.HasRows);

                // 3. Clear the table... because maybe there was something there before?
                dgConvidado.Rows.Clear();
                Console.WriteLine("linhas limpas");

                // 4. Reader.Read() means to make a read for each row in the resulting query.
                //    It returns back a boolean value when it's called, so it can be used as
                //    the base-case of this while-loop. Once it can no longer read, or has run out of rows to read,
                //    then reader.Read() returns false and the while-loop terminates.
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgConvidado.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                                  
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    Console.WriteLine("applied ID");
                    
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    Console.WriteLine("applied NOME");
                    
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    Console.WriteLine("applied EMAIL");
                    
                    row.Cells[3].Value = reader.GetString(3);//TELEFONE
                    Console.WriteLine("applied TELEFONE");
                    
                    row.Cells[4].Value = reader.GetInt32(4);//ACOMPANHANTE
                    Console.WriteLine("applied Acompanhante");

                    dgConvidado.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }
                Console.WriteLine("encheu a tabela");

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO convidado (nomeConvidado,emailConvidado,telConvidado,acompanhanteConvidado) " +
                    "VALUES('" + txtNome.Text + "', '" + txtEmail.Text + "','" + mtxtTelefone.Text + "', " + Convert.ToInt16(cbAcompanhantes.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            mtxtTelefone.Clear();
            txtEmail.Clear();
            cbAcompanhantes.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                comandoMySql.CommandText = "DELETE FROM convidado WHERE idConvidado = " + txtID.Text + "";
                //comandoMySql.CommandText = "UPDATE filme SET ativoFilme = 0 WHERE idFilme = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE convidado SET nomeConvidado = '" + txtNome.Text + "', " +
                    "emailConvidado = '" + txtEmail.Text + "', " +
                    "telConvidado = '" + mtxtTelefone.Text + "', " +
                    "acompanhanteConvidado = " + Convert.ToInt16(cbAcompanhantes.Text) +
                    " WHERE idConvidado = " + txtID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgConvidado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgConvidado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgConvidado.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                txtNome.Text = dgConvidado.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                txtEmail.Text = dgConvidado.Rows[e.RowIndex].Cells["colEmail"].FormattedValue.ToString();
                mtxtTelefone.Text = dgConvidado.Rows[e.RowIndex].Cells["colTelefone"].FormattedValue.ToString();
                cbAcompanhantes.Text = dgConvidado.Rows[e.RowIndex].Cells["colAcompanhante"].FormattedValue.ToString();
                txtID.Text = dgConvidado.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
            }
        }
    }
}
