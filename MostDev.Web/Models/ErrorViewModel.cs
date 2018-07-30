#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Web.ErrorViewModel.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}