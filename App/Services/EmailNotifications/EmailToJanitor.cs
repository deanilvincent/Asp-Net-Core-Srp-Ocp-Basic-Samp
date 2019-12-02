using System;
using System.Diagnostics;
using System.Threading.Tasks;
using App.ServiceContracts;

namespace App.Services.EmailNotifications
{
    public class EmailToJanitor : IEmailNotification
    {
        public bool Rule(string rule)
        {
            return rule.Equals("email-to-janitor");
        }

        public async Task<bool> NotifyUser(string info)
        {
            try
            {
                // async custom email body for janitor staff goes here
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
