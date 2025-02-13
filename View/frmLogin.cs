using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
