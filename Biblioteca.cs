using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoWagnerBiblioteca
{
    public partial class Biblioteca : Form
    {
  

        private LivroDAO _livroDAO = new LivroDAO();

        public Biblioteca()
        {
            InitializeComponent();
        }

       
        private void Biblioteca_Load(object sender, EventArgs e)
        {
            LoadAutores();
            LoadCategorias();
            LoadLivros();
        }

        private void LoadLivros()
        {
            try
            {
                dgvLivros.DataSource = _livroDAO.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void LoadAutores()
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = "SELECT id, nome FROM Autores";
                var cmd = new MySqlCommand(query, connection);
                var reader = cmd.ExecuteReader();

                var dataTable = new System.Data.DataTable();
                dataTable.Load(reader);

                cmbAutor.DataSource = dataTable;
                cmbAutor.DisplayMember = "nome";
                cmbAutor.ValueMember = "id";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void LoadCategorias()
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = "SELECT id, nome FROM Categorias";
                var cmd = new MySqlCommand(query, connection);
                var reader = cmd.ExecuteReader();

                var dataTable = new System.Data.DataTable();
                dataTable.Load(reader);

                cmbCategoria.DataSource = dataTable;
                cmbCategoria.DisplayMember = "nome";
                cmbCategoria.ValueMember = "id";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }

       

        private void BtnAddLivro_Click(object sender, EventArgs e)
        {
            try
            {
                int autorId = Convert.ToInt32(cmbAutor.SelectedValue);
                int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

                _livroDAO.Add(txtTitulo.Text, dtpAnoPublicacao.Value, autorId, categoriaId);
                MessageBox.Show("Livro adicionado com sucesso!");
                LoadLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar livro: " + ex.Message);
            }
        }

        private void BtnEditLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLivros.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvLivros.CurrentRow.Cells["id"].Value);
                    int autorId = Convert.ToInt32(cmbAutor.SelectedValue);
                    int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

                    _livroDAO.Update(id, txtTitulo.Text, dtpAnoPublicacao.Value, autorId, categoriaId);
                    MessageBox.Show("Livro atualizado com sucesso!");
                    LoadLivros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar livro: " + ex.Message);
            }
        }

        private void BtnDeleteLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLivros.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvLivros.CurrentRow.Cells["id"].Value);
                    _livroDAO.Delete(id);
                    MessageBox.Show("Livro excluído com sucesso!");
                    LoadLivros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir livro: " + ex.Message);
            }
        }

        private void BtnAddAutor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNovoAutor.Text))
                {
                    MessageBox.Show("Digite o nome do autor.");
                    return;
                }

                _livroDAO.AddAutor(txtNovoAutor.Text);
                MessageBox.Show("Autor adicionado com sucesso!");
                txtNovoAutor.Clear();
                LoadAutores(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar autor: " + ex.Message);
            }
        }

        private void BtnAddCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNovaCategoria.Text))
                {
                    MessageBox.Show("Digite o nome da categoria.");
                    return;
                }

                _livroDAO.AddCategoria(txtNovaCategoria.Text);
                MessageBox.Show("Categoria adicionada com sucesso!");
                txtNovaCategoria.Clear();
                LoadCategorias(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar categoria: " + ex.Message);
            }
        }


    }
}
