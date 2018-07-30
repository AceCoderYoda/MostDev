#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Threading.Logic.JsonManager.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Newtonsoft.Json;

#endregion

namespace MostDev.Threading.Logic
{
    public class JsonManager
    {
        public string ConvertToJson(User user)
        {
            return JsonConvert.SerializeObject(user);
        }

        public User ConvertToJson(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<User>(stringToDeserialize);
        }
    }
}