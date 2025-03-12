using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Estoque.Entities;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Estoque.DAL
{
    public class ProdutoDAL
    {
        public static string strConnection = "server=127.0.0.1;port=3306;User Id=root;database=estoquedb;password=J#nsen1804";

        #region Inserir
        public void InserirProduto(Produto produto)
        {
            try
            {
                
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InserirProdutos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Nome", produto.Nome);
                        cmd.Parameters.AddWithValue("p_Categoria", produto.Categoria);
                        cmd.Parameters.AddWithValue("p_Quantidade", produto.Quantidade);
                        cmd.Parameters.AddWithValue("p_Preco", produto.Preco);
                        cmd.Parameters.AddWithValue("p_FornecedorID", produto.FornecedorID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir produto: " + ex.Message);
            }
        }
        #endregion

        #region Editar
        public void EditarProduto(Produto produto)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("EditarProdutos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", produto.ID);
                        cmd.Parameters.AddWithValue("p_Nome", produto.Nome);
                        cmd.Parameters.AddWithValue("p_Categoria", produto.Categoria);
                        cmd.Parameters.AddWithValue("p_Quantidade", produto.Quantidade);
                        cmd.Parameters.AddWithValue("p_Preco", produto.Preco);
                        cmd.Parameters.AddWithValue("p_FornecedorID", produto.FornecedorID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar produto: " + ex.Message);
            }
        }
        #endregion

        #region Buscar
        public List<Produto> BuscarProduto(string nome, string categoria)
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("BuscarProdutos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Nome", nome ?? string.Empty);
                        cmd.Parameters.AddWithValue("p_Categoria", categoria ?? string.Empty);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                produtos.Add(new Produto
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                    Categoria = reader.IsDBNull(reader.GetOrdinal("Categoria")) ? null : reader.GetString(reader.GetOrdinal("Categoria")),
                                    Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade")),
                                    Preco = reader.GetDecimal(reader.GetOrdinal("Preco")),
                                    FornecedorID = reader.IsDBNull(reader.GetOrdinal("FornecedorID")) ? 0 : reader.GetInt32(reader.GetOrdinal("FornecedorID"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar produtos: " + ex.Message);
            }

            return produtos;
        }
        #endregion

        #region Deletar
        public void DeletarProduto(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DeletarProdutos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar produto: " + ex.Message);
            }
        }
        #endregion


    }
}
