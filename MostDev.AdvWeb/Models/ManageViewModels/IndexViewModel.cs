#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.AdvWeb.IndexViewModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.ComponentModel.DataAnnotations;

#endregion

namespace MostDev.AdvWeb.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}