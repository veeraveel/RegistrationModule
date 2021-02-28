using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web.Service
{
    public interface IMailService
    {

        Task SendEmailAsync(string toEmail, string subject, string content);
    }

    public class SendGridMailService : IMailService
    {
       
        Task IMailService.SendEmailAsync(string toEmail, string subject, string content)
        {
            
        }
    }
}
