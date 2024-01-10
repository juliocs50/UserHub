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
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "DataCadastro";
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
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["ID"], reader["Nome"], reader["Email"], reader["DataCadastro"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label5.Text = $"Erro ao carregar contatos: {ex.Message}";
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
                label5.Text = $"Erro ao adicionar contato: {ex.Message}";
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
                label5.Text = $"Erro ao editar contato: {ex.Message}";
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
                label5.Text = $"Erro ao excluir contato: {ex.Message}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarContato(textBox1.Text, textBox2.Text, DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                EditarContato(id, textBox1.Text, textBox2.Text, DateTime.Now);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                ExcluirContato(id);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Lógica a ser executada durante o carregamento do formulário, se necessário
        }

    }
}
