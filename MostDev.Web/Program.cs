#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Web.Program.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

#endregion

namespace MostDev.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}