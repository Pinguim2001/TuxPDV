using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuxPDV.Service
{
    public class EmailService
    {
        private static Dictionary<string, string> resetCodes = new Dictionary<string, string>();
        public void SendResetPassword(string _userEmail)
        {
            string resetCode = GenerateResetCode();
            resetCodes[_userEmail] = resetCode;

            string subject = "Código Para Redefinição de Senha";
            string body = $"Seu código de redefinição de senha é {resetCode}.Não compartilhe este código com ninguém.";

            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("NAORESPONDA@tuxpdv.com.br");
                mailMessage.To.Add(_userEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.orquidea.com.br", 53);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(mailMessage);

                MessageBox.Show("Enviado com sucesso!!!",
                               "SUCESSO",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro ao enviar e-mail",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private string GenerateResetCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        public bool ValidateResetCode(string _userEmail, string _userCode)
        {
            if (resetCodes.ContainsKey(_userEmail) && resetCodes[_userEmail] == _userCode)
            {
                resetCodes.Remove(_userEmail);
                return true;
            }

            return false;
        }
    }
}
