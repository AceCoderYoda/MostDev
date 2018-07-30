#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.ExternalLoginsViewModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

#endregion

namespace MostDev.AdvWeb.Models.ManageViewModels
{
    public class ExternalLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }

        public bool ShowRemoveButton { get; set; }

        public string StatusMessage { get; set; }
    }
}