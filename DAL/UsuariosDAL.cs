using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Sistema_de_Estoque.Entities;
using Sistema_de_Estoque.Utils;

namespace Sistema_de_Estoque.DAL
{
    public class UsuariosDAL
    {
        private readonly string strConnection = "server=127.0.0.1;port=3306;User Id=root;database=curso_db;password=J#nsen1804";

        #region Inserir
        public void InserirUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InserirUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("p_Login", usuario.Login);
                        cmd.Parameters.AddWithValue("p_Senha", SecurityHelper.GerarHashSHA256(usuario.Senha));
                        cmd.Parameters.AddWithValue("p_NivelAcesso", usuario.NivelAcesso);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir usuário: " + ex.Message);
            }
        }
        #endregion

        #region Buscar
        public List<Usuario> BuscarUsuarios(string nome, string login)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (var connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (var command = new MySqlCommand("BuscarUsuarios", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("p_Nome", nome ?? string.Empty);
                        command.Parameters.AddWithValue("p_Login", login ?? string.Empty);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios.Add(new Usuario
                                {
                                    ID = reader.GetInt32("ID"),
                                    Nome = reader.GetString("Nome"),
                                    Login = reader.GetString("Login"),
                                    Senha = reader.GetString("Senha"),
                                    NivelAcesso = reader.GetString("NivelAcesso")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuários: " + ex.Message);
            }

            return usuarios;
        }
        #endregion

        #region Editar
        public void EditarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("EditarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", usuario.ID);
                        cmd.Parameters.AddWithValue("p_Nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("p_Login", usuario.Login);
                        cmd.Parameters.AddWithValue("p_NivelAcesso", usuario.NivelAcesso);

                        if (!string.IsNullOrEmpty(usuario.Senha))
                        {
                            cmd.Parameters.AddWithValue("p_Senha", SecurityHelper.GerarHashSHA256(usuario.Senha));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("p_Senha", DBNull.Value); // Não altera a senha
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar usuário: " + ex.Message);
            }
        }

        #endregion

        #region Deletar
        public void Deletar(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DeletarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar usuário: " + ex.Message);
            }
        }
        #endregion
    }
}
