using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuxPDV.Enum;
using TuxPDV.Service;

namespace TuxPDV.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lnkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEsqueceuSenha esqueceuSenha = new frmEsqueceuSenha();
            esqueceuSenha.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioService usuService = new UsuarioService();

            string login = txtLogin.Text;
            string password = txtPassword.Text;

            Boolean aut = usuService.autUser(login, password);

            if (!(aut))
            {
                txtLogin.Clear();
                txtPassword.Clear();
                txtLogin.Focus();
                return;
            }

            TipoUsuario type = usuService.getTypeUser(login);
        }
    }
}
