using System;
using System.Threading.Tasks;

namespace SendEmail.Site.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string messages);
    }
}
