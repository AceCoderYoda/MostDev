#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.ForgotPasswordViewModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.ComponentModel.DataAnnotations;

#endregion

namespace MostDev.AdvWeb.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}