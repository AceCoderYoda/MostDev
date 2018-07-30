#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.EmailSenderExtensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Text.Encodings.Web;
using System.Threading.Tasks;

#endregion

namespace MostDev.AdvWeb.Services
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}