// Form1.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=AgendaContatos;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
            dataGridViewContatos.CellContentClick += dataGridViewContatos_CellContentClick;
            CarregarContatos();
        }

        private void InicializarDataGridView()
        {

            dataGridViewContatos.ColumnCount = 4;
            dataGridViewContatos.Columns[0].Name = "ID";
            dataGridViewContatos.Columns[1].Name = "Nome";
            dataGridViewContatos.Columns[2].Name = "Email";
            dataGridViewContatos.Columns[3].Name = "DataCadastro";
            dataGridViewContatos.AllowUserToAddRows = false;

        }

        private void CarregarContatos()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "SELECT ID, Nome, Email, DataCadastro FROM Contatos";
                    SqlCommand comando = new SqlCommand(query, conexao);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        dataGridViewContatos.Rows.Clear();

                        AdicionarColuna("Editar");
                        AdicionarColuna("Excluir");

                        while (reader.Read())
                        {
                            dataGridViewContatos.Rows.Add(reader["ID"], reader["Nome"], reader["Email"], reader["DataCadastro"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                labelLog.Text = $"Erro ao carregar contatos: {ex.Message}";
            }
        }
        private void dataGridViewContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewContatos.Columns[e.ColumnIndex].Name;

                if (columnName == "Editar")
                {
                    int id = Convert.ToInt32(dataGridViewContatos.Rows[e.RowIndex].Cells["ID"].Value);
                    string nome = Convert.ToString(dataGridViewContatos.Rows[e.RowIndex].Cells["Nome"].Value);
                    string email = Convert.ToString(dataGridViewContatos.Rows[e.RowIndex].Cells["Email"].Value);
                    DateTime dataCadastro = Convert.ToDateTime(dataGridViewContatos.Rows[e.RowIndex].Cells["DataCadastro"].Value);

                    EditarContato(id, nome, email, dataCadastro);
                }
                else if (columnName == "Excluir")
                {
                    int id = Convert.ToInt32(dataGridViewContatos.Rows[e.RowIndex].Cells["ID"].Value);
                    ExcluirContato(id);
                }
            }
        }

        private void AdicionarColuna(string nomeBotao)
        {
            if (!dataGridViewContatos.Columns.Contains(nomeBotao))
            {
                DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();
                colunaBotao.Name = nomeBotao;
                colunaBotao.HeaderText = "";
                colunaBotao.Text = nomeBotao;
                colunaBotao.UseColumnTextForButtonValue = true;
                dataGridViewContatos.Columns.Add(colunaBotao);
            }
        }

        private void AdicionarContato(string nome, string email, DateTime dataCadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "INSERT INTO Contatos (Nome, Email, DataCadastro) VALUES (@Nome, @Email, @DataCadastro)";
                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@DataCadastro", dataCadastro);

                    comando.ExecuteNonQuery();
                }

                CarregarContatos();
            }
            catch (Exception ex)
            {
                labelLog.Text = $"Erro ao adicionar contato: {ex.Message}";
            }
        }

        private void EditarContato(int id, string nome, string email, DateTime dataCadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE Contatos SET Nome = @Nome, Email = @Email, DataCadastro = @DataCadastro WHERE ID = @ID";
                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@ID", id);
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@DataCadastro", dataCadastro);

                    comando.ExecuteNonQuery();
                }

                CarregarContatos();
            }
            catch (Exception ex)
            {
                labelLog.Text = $"Erro ao editar contato: {ex.Message}";
            }
        }

        private void ExcluirContato(int id)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "DELETE FROM Contatos WHERE ID = @ID";
                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@ID", id);

                    comando.ExecuteNonQuery();
                }

                CarregarContatos();
            }
            catch (Exception ex)
            {
                labelLog.Text = $"Erro ao excluir contato: {ex.Message}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarContato(textBoxCadastroNome.Text, textBoxCadastroEmail.Text, DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }


        private void button4_Click(object sender, EventArgs e) { }


        private void textBox2_TextChanged(object sender, EventArgs e) { }


        private void textBox1_TextChanged(object sender, EventArgs e) { }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime dataInicio = dateTimePicker1.Value;
            DateTime dataFim = dateTimePicker2.Value;

            string consultaSQL = "SELECT * FROM Contatos WHERE DataCadastro BETWEEN @DataInicio AND @DataFim";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@DataInicio", dataInicio);
                    comando.Parameters.AddWithValue("@DataFim", dataFim);

                    try
                    {
                        conexao.Open();
                        SqlDataReader reader = comando.ExecuteReader();
                        dataGridViewContatos.Rows.Clear();

                        AdicionarColuna("Editar");
                        AdicionarColuna("Excluir");

                        while (reader.Read())
                        {

                            dataGridViewContatos.Rows.Add(reader["ID"], reader["Nome"], reader["Email"], reader["DataCadastro"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message);
                    }
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) { }


        private void button3_Click_1(object sender, EventArgs e)
        {
            string nome = textBox2.Text;


            string consultaSQL = "SELECT * FROM Contatos WHERE Nome = @Nome";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);

                    try
                    {
                        conexao.Open();
                        SqlDataReader reader = comando.ExecuteReader();
                        dataGridViewContatos.Rows.Clear();

                        AdicionarColuna("Editar");
                        AdicionarColuna("Excluir");

                        while (reader.Read())
                        {

                            dataGridViewContatos.Rows.Add(reader["ID"], reader["Nome"], reader["Email"], reader["DataCadastro"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string email = textBox1.Text;


            string consultaSQL = "SELECT * FROM Contatos WHERE Email = @Email";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conexao.Open();
                        SqlDataReader reader = comando.ExecuteReader();
                        dataGridViewContatos.Rows.Clear();

                        AdicionarColuna("Editar");
                        AdicionarColuna("Excluir");

                        while (reader.Read())
                        {

                            dataGridViewContatos.Rows.Add(reader["ID"], reader["Nome"], reader["Email"], reader["DataCadastro"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message);
                    }
                }
            }
        }
    }
}
