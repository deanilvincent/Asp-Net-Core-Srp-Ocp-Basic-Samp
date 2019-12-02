using System.Threading.Tasks;
using App.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IEmailNotificationService emailNotif;

        public TestController(IEmailNotificationService emailNotif)
        {
            this.emailNotif = emailNotif;
        }

        public async Task<IActionResult> TestMethod()
        {
            return Ok(await emailNotif.SendEmail("email-to-janitor", "blah"));
            //return Ok(await emailNotif.SendEmail("email-to-supervisor", "blah"));
            //return Ok(await emailNotif.SendEmail("email-to-waitress", "blah"));
        }
    }
}
