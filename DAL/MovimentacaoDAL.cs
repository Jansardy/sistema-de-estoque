using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estoque.DAL
{
    public class MovimentacaoDAL
    {

        private readonly string strConnection = "server=localhost;port=3306;User Id=root;database=estoquedb;password=J#nsen1804";

        public void EntradaEstoque(int produtoID, int quantidade, int fornecedorID)
        {
            using (MySqlConnection con = new MySqlConnection(strConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("EntradaEstoque", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProdutoID", produtoID);
                    cmd.Parameters.AddWithValue("@p_Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@p_FornecedorID", fornecedorID);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaidaEstoque(int produtoID, int quantidade, string motivo)
        {
            using (MySqlConnection con = new MySqlConnection(strConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("EntradaEstoque", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProdutoID", produtoID);
                    cmd.Parameters.AddWithValue("@p_Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@p_Motivo", motivo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception("Erro ao registrar saída de estoque: " + ex.Message);
                    }
                }
            }
        }

    }
}
