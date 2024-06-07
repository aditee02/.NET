

using System.Threading.Tasks;

namespace VehicalRentalSystem1.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}