using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using pavlovLab.Models;

namespace pavlovLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var versionInfo = new Version
            {
                ProductVersion = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion
            };

            return Ok(versionInfo);
        }
    }
}