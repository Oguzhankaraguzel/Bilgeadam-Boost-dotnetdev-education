using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using MyCompany.Management.Service.Configurations;
using MyCompany.Management.Service.Models;

namespace AppUser.Management.Service.Services
{
    public class EMailService : IEmailService
	{
		private readonly EmailConfig _emailConfig;
		public EMailService(EmailConfig emailConfig)
		{
			//DEPENDENCY INJECTION
			_emailConfig = emailConfig;
		}

		public void SendEmail(MailMessage mailMessage)
		{
			var emailMessage = CreateEmailMessage(mailMessage);
			Send(emailMessage);
		}

		private void Send(MimeMessage emailMessage)
		{
			using (var client = new SmtpClient())
			{
				try
				{
					client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
					client.AuthenticationMechanisms.Remove("XOAUTH2");
					client.Authenticate(_emailConfig.Username, _emailConfig.Password);
					client.Send(emailMessage);
				}
				catch(Exception ex)
				{

				}
				finally {
					client.Disconnect(true);
					client.Dispose();
				}
			}
		}

		private MimeMessage CreateEmailMessage(MailMessage mailMessage)
		{
			MimeMessage emailMessage = new MimeMessage();
			emailMessage.From.Add(new MailboxAddress("Fatih Kaan Açıkgöz (UDEMY)", _emailConfig.From));
			emailMessage.To.AddRange(mailMessage.To);
			emailMessage.Subject = mailMessage.Subject;
			emailMessage.Body = new TextPart(TextFormat.Html) { Text= mailMessage.Body };
			return emailMessage;

		}
	}
}
