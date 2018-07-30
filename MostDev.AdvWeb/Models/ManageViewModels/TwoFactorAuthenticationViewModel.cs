#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.TwoFactorAuthenticationViewModel.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.AdvWeb.Models.ManageViewModels
{
    public class TwoFactorAuthenticationViewModel
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}