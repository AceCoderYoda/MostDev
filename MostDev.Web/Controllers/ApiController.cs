#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Web.ApiController.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Microsoft.AspNetCore.Mvc;

#endregion

namespace MostDev.Web.Controllers
{
    public class ApiController : Controller
    {
        [Route("api/data")]
        public IActionResult GetSomeData()
        {
            return Ok(new SomeObject
            {
                Name = "hellao",
                Age = 383
            });
        }
    }

    public class SomeObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}