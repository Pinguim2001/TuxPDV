using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuxPDV.Service;

namespace TuxPDV.View
{
    public partial class frmEsqueceuSenha : Form
    {
        private Timer timer = new Timer();
        private int remainingTime = 90;

        private EmailService emailService = new EmailService();

        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void frmEsqueceuSenha_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_tick);
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Por favor, Isira um e-mail");
                return;
            }

            btnEnviarEmail.Enabled = false;
            remainingTime = 90;
            timer.Start();
            UpdateTimerDisplay();
            emailService.SendResetPassword(userEmail);
            
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if(remainingTime > 0)
            {
                remainingTime--;
                UpdateTimerDisplay();
            }
            else
            {
                timer.Stop();
                btnEnviarEmail.Enabled = true;
            }
        }

        private void UpdateTimerDisplay() 
        {
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            lblTimer.Text = "Aguarde..." + string.Format("{0:D2}:{1:D2}", minutes, seconds);
        }

        private void btnVerificaCode_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text; 
            string userCode = txtCodRecup.Text;

            if (string.IsNullOrEmpty(userCode))
            {
                MessageBox.Show("Por favor insira o código recebido!");
                return;
            }

            if(!(emailService.ValidateResetCode(userEmail, userCode)))
            {
                MessageBox.Show("Código Inválido");
                return;
            }



        }
    }
}
