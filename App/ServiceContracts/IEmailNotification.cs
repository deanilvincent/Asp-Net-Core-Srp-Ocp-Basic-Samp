using System.Threading.Tasks;

namespace App.ServiceContracts
{
    public interface IEmailNotification
    {
        bool Rule(string rule);
        Task<bool> NotifyUser(string info);
    }
}