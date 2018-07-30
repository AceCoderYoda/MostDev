#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.EmailSender.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Threading.Tasks;

#endregion

namespace MostDev.AdvWeb.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}