﻿using System;
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
    public partial class frmHomeAdmin : Form
    {
        public frmHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();

        }
    }
}
