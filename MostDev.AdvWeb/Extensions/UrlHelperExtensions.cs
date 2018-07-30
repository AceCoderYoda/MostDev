#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.UrlHelperExtensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using MostDev.AdvWeb.Controllers;

#endregion

namespace Microsoft.AspNetCore.Mvc
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                nameof(AccountController.ConfirmEmail),
                "Account",
                new {userId, code},
                scheme);
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code,
            string scheme)
        {
            return urlHelper.Action(
                nameof(AccountController.ResetPassword),
                "Account",
                new {userId, code},
                scheme);
        }
    }
}