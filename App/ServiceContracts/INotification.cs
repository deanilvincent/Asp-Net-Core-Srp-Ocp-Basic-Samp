using System.Threading.Tasks;

namespace App.ServiceContracts
{
    public interface INotification
    {
        bool Rule(string rule);
        Task<bool> NotifyUser(string info);
    }
}