using MyCompany.Management.Service.Models;

namespace AppUser.Management.Service.Services
{
    public interface IEmailService
    {
        void SendEmail(MailMessage mailMessage);
    }
}
