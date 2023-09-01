using MimeKit;

namespace MyCompany.Management.Service.Models
{
    public class MailMessage
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public MailMessage(IDictionary<string, string> to, string subject, string body)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(recipient => new MailboxAddress(recipient.Key, recipient.Value)));
            Subject = subject;
            Body = body;
        }
    }
}
