#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Threading.Logic.User.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.Threading.Logic
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
    }
}