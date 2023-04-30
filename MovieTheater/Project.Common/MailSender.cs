using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Project.Common
{
    public static class MailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            //egehan.test@hotmail.com

            //MailMessage
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("egehan.test@hotmail.com","MovieTheater");
            sender.Subject = subject;
            sender.Body = message;
            sender.To.Add(email);

            //SmtpClient
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("egehan.test@hotmail.com", "Yzl3162--");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;

            //Sending
            smtpClient.Send(sender);

        }
    }
}
