using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace meshapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        

        private readonly ILogger<SettingsController> _logger;
        private readonly IConfiguration Configuration;

        public SettingsController(ILogger<SettingsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        [HttpGet]
        public Settings Get()
        {
            return new Settings()
            {
                Color = Configuration["Color"]
            };
        }
    }
}
