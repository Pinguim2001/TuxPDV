using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuxPDV.Enum;
using TuxPDV.Model;

namespace TuxPDV.DAO
{
    public class UsuarioDAO
    {
        private string connection = "Data Source=localhost;Initial Catalog=tuxPDV;Integrated Security=True";

        public bool insert(Usuarios _user)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "INSERT INTO USUARIOS (Login, Nome, Email, Senha, Tipo) VALUES (@Login, @Nome, @Email, @Senha, @Tipo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", _user.Login);
                    cmd.Parameters.AddWithValue("@Nome", _user.Nome);
                    cmd.Parameters.AddWithValue("@Email", _user.Email);
                    cmd.Parameters.AddWithValue("@Senha", _user.Senha);
                    cmd.Parameters.AddWithValue("@Tipo", _user.Tipo);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public List<Usuarios> listUsers()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            using(SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT * FROM USUARIOS";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            usuarios.Add(new Usuarios
                            {
                                Login = reader["Login"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                Tipo = (TipoUsuario)Convert.ToInt32(reader["Tipo"])
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao listar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return usuarios;
        }

        public TipoUsuario typeUser(string _login)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT TIPO FROM USUARIOS WHERE LOGIN = @Login";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", _login);

                    try
                    {
                        conn.Open();
                        object res = (int)cmd.ExecuteScalar();

                        if (res != null)
                            return (TipoUsuario)Convert.ToInt32(res);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return TipoUsuario.FUNCIONARIO;
        }

        public bool getUser(string _login, string _password)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT COUNT(*) FROM USUARIOS WHERE LOGIN = @Login AND SENHA = @Senha";
                
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@Login", _login);
                    cmd.Parameters.AddWithValue("@Senha", _password);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
