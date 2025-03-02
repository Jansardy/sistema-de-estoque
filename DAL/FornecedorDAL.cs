using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Estoque.Entities;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_de_Estoque.DAL
{
    public class FornecedorDAL
    {
        private readonly string strConnection = "server=127.0.0.1;port=3306;User Id=root;database=curso_db;password=J#nsen1804";

        #region Inserir
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InserirFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Nome", fornecedor.Nome);
                        cmd.Parameters.AddWithValue("p_Contato", fornecedor.Contato);
                        cmd.Parameters.AddWithValue("p_Endereco", fornecedor.Endereco);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir fornecedor: " + ex.Message);
            }
        }
        #endregion

        #region Editar
        public void EditarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("EditarFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", fornecedor.ID);
                        cmd.Parameters.AddWithValue("p_Nome", fornecedor.Nome);
                        cmd.Parameters.AddWithValue("p_Contato", fornecedor.Contato);
                        cmd.Parameters.AddWithValue("p_Endereco", fornecedor.Endereco);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar fornecedor: " + ex.Message);
            }
        }
        #endregion

        #region Buscar
        public List<Fornecedor> BuscarFornecedor(string nome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("BuscarFornecedores", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Nome", nome ?? string.Empty);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                fornecedores.Add(new Fornecedor
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                    Contato = reader.GetString(reader.GetOrdinal("Contato")),
                                    Endereco = reader.IsDBNull(reader.GetOrdinal("Endereco")) ? null : reader.GetString(reader.GetOrdinal("Endereco"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar fornecedor: " + ex.Message);
            }

            return fornecedores;
        }
        #endregion


        #region Deletar
        public void DeletarFornecedor(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DeletarFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar fornecedor: " + ex.Message);
            }
        }
        #endregion
    }
}
