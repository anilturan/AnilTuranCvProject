using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AnilTuran.Models
{
    public class EmailHelper
    {
        public static void MailSender(string body, string subject)
        {
            string gmail = "teamd.iletisim@gmail.com";
            var fromAdress = new MailAddress(gmail);
            var toAdress = new MailAddress(gmail);

            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAdress.Address, "TeamD12345")


            })
            {
                using (var message = new MailMessage(fromAdress, toAdress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }

            }
        }
    }
}