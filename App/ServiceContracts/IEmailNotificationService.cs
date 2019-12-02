using System.Threading.Tasks;

namespace App.ServiceContracts
{
    public interface IEmailNotificationService
    {
        Task<bool> SendEmail(string rule, string info);
    }
}