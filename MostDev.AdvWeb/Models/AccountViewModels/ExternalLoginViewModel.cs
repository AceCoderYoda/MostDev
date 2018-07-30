#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.ExternalLoginViewModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.ComponentModel.DataAnnotations;

#endregion

namespace MostDev.AdvWeb.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}