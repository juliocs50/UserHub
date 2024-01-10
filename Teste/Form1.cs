// Form1.cs
using System;
using System.Data;
using System.Data.SqlClient;
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
            CarregarContatos();
        }

        private void InicializarDataGridView()
        {
            dataGridViewContatos.ColumnCount = 4;
            dataGridViewContatos.Columns[0].Name = "ID";
            dataGridViewContatos.Columns[1].Name = "Nome";
            dataGridViewContatos.Columns[2].Name = "Email";
            dataGridViewContatos.Columns[3].Name = "DataCadastro";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewContatos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewContatos.SelectedRows[0].Cells["ID"].Value);
                EditarContato(id, textBoxCadastroNome.Text, textBoxCadastroEmail.Text, DateTime.Now);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewContatos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewContatos.SelectedRows[0].Cells["ID"].Value);
                ExcluirContato(id);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Lógica a ser executada durante o carregamento do formulário, se necessário
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
