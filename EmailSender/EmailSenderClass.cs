
using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public class EmailSenderClass : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "mshirish2002@gmail.com";
            var pw = ""; //replace this part with email password

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));
        }
    }
}
