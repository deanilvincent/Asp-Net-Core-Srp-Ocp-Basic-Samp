using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.ServiceContracts;

namespace App.Services.EmailNotifications
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly List<INotification> notifications;

        public EmailNotificationService(List<INotification> notifications)
        {
            this.notifications = notifications;
        }

        public async Task<bool> SendEmail(string rule, string info)
        {
            if (!string.IsNullOrEmpty(rule))
            {
                return await notifications.FirstOrDefault(x => x.Rule(rule)).NotifyUser(info);
            }

            return false;
        }
    }
}
