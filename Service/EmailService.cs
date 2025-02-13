using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
                SmtpClient smtp = new SmtpClient("smtp.zimbra.orquidea.com.br")
                {
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                MailMessage message = new MailMessage
                {
                    From = new MailAddress("alyssondornelles123@hotmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };

                message.To.Add(_userEmail);

                smtp.Send(message);
                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
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
