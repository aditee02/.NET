using Microsoft.Extensions.Options;
using MimeKit;
using VehicalRentalSystem1.Services;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using VehicalRentalSystem1.ViewModel;

namespace VehicalRentalSystem1.Services
{
    public class SmtpEmailService : IEmailService
    {
        private readonly SmtpSettings _smtpSettings;

        public SmtpEmailService(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sender Name", _smtpSettings.Username));
            message.To.Add(new MailboxAddress("Recipient Name", toEmail));

            message.Subject = subject;

            var textBody = new TextPart("plain")
            {
                Text = body
            };

            var multipart = new Multipart("alternative");
            multipart.Add(textBody);

            message.Body = multipart;

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_smtpSettings.Server, _smtpSettings.Port, useSsl: true);
                await client.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}