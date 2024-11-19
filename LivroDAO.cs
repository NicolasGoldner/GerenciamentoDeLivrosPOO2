using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace TrabalhoWagnerBiblioteca
{
    public class LivroDAO
    {
        public DataTable GetAll()
        {
            var dt = new DataTable();
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = @"
                    SELECT 
                        Livros.id, 
                        Livros.titulo, 
                        Livros.ano_publicacao, 
                        Autores.nome AS autor, 
                        Categorias.nome AS categoria
                    FROM Livros
                    INNER JOIN Autores ON Livros.autor_id = Autores.id
                    INNER JOIN Categorias ON Livros.categoria_id = Categorias.id";

                var adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter livros: " + ex.Message);
            }

            return dt;
        }

        public void Add(string titulo, DateTime anoPublicacao, int autorId, int categoriaId)
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = @"
                    INSERT INTO Livros (titulo, ano_publicacao, autor_id, categoria_id) 
                    VALUES (@titulo, @anoPublicacao, @autorId, @categoriaId)";

                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@anoPublicacao", anoPublicacao.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@autorId", autorId);
                cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar livro: " + ex.Message);
            }
        }

        public void Update(int id, string titulo, DateTime anoPublicacao, int autorId, int categoriaId)
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = @"
                    UPDATE Livros 
                    SET titulo = @titulo, 
                        ano_publicacao = @anoPublicacao, 
                        autor_id = @autorId, 
                        categoria_id = @categoriaId 
                    WHERE id = @id";

                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@anoPublicacao", anoPublicacao.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@autorId", autorId);
                cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar livro: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = "DELETE FROM Livros WHERE id = @id";

                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir livro: " + ex.Message);
            }
        }


        public void AddAutor(string nome)
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = "INSERT INTO Autores (nome) VALUES (@nome)";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar autor: " + ex.Message);
            }
        }

        public void AddCategoria(string nome)
        {
            try
            {
                var connection = DatabaseConnection.Instance.Connection;

                string query = "INSERT INTO Categorias (nome) VALUES (@nome)";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar categoria: " + ex.Message);
            }
        }

    }
}
