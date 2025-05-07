using MySql.Data.MySqlClient;
using Sistema_de_Estoque.Entities;
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

        #region Entrada
        public void EntradaEstoque(MovimentacaoEstoque movimentacao)
        {
            using (MySqlConnection con = new MySqlConnection(strConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("EntradaEstoque", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProdutoID", movimentacao.ProdutoId);
                    cmd.Parameters.AddWithValue("@p_Quantidade", movimentacao.Quantidade);
                    cmd.Parameters.AddWithValue("@p_FornecedorID", movimentacao.FornecedorId);
                    cmd.Parameters.AddWithValue("@p_UsuarioID", movimentacao.UsuarioId);
                    //cmd.Parameters.AddWithValue("@p_DataMovimentacao", movimentacao.DataMovimentacao);
                    cmd.Parameters.AddWithValue("@p_Tipo", movimentacao.Tipo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception("Erro ao registrar entrada de estoque: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Saída
        public void SaidaEstoque(MovimentacaoEstoque movimentacao, string motivo)
        {
            using (MySqlConnection con = new MySqlConnection(strConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SaidaEstoque", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProdutoID", movimentacao.ProdutoId);
                    cmd.Parameters.AddWithValue("@p_Quantidade", movimentacao.Quantidade);
                    cmd.Parameters.AddWithValue("@p_UsuarioID", movimentacao.UsuarioId);
                    //cmd.Parameters.AddWithValue("@p_DataMovimentacao", movimentacao.DataMovimentacao);
                    cmd.Parameters.AddWithValue("@p_Tipo", movimentacao.Tipo);
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
        #endregion

        #region Relatório

        #endregion

    }
}
