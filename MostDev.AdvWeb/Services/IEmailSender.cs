#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.IEmailSender.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Threading.Tasks;

#endregion

namespace MostDev.AdvWeb.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}