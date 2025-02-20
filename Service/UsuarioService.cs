using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuxPDV.DAO;
using TuxPDV.Enum;

namespace TuxPDV.Service
{
    public class UsuarioService
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        public bool autUser(string _login, string _password)
        {
            if (string.IsNullOrEmpty(_login) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Digite o usuário e senha!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(usuarioDAO.getUser(_login, _password))){
                MessageBox.Show("Usuário" + _login + " não encontrado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public TipoUsuario getTypeUser(string _login)
        {
            return usuarioDAO.typeUser(_login);
        }
    }
}
