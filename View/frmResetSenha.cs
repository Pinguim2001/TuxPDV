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
    public partial class frmResetSenha : Form
    {
        public frmResetSenha()
        {
            InitializeComponent();
        }

        private void btnSalvarNovaSenha_Click(object sender, EventArgs e)
        {
            if(!(txtNovaSenha.Text.Equals(txtConfirNovaSenha.Text)))
            {
                MessageBox.Show("AS senhas não conferem!!");
                return;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
