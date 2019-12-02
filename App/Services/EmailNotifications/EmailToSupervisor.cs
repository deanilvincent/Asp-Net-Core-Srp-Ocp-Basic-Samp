using System;
using System.Diagnostics;
using System.Threading.Tasks;
using App.ServiceContracts;

namespace App.Services.EmailNotifications
{
    public class EmailToSupervisor : IEmailNotification
    {
        public bool Rule(string rule)
        {
            return rule.Equals("email-to-supervisor");
        }

        public async Task<bool> NotifyUser(string info)
        {
            try
            {
                // async custom email body for supervisor staff goes here
                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                // or put exc to logger service
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}
