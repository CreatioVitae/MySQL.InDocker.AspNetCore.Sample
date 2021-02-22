using MicroORMWrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApp.MySQLTest.DatabaseConnections;
using WebApp.MySQLTest.Models;

namespace WebApp.MySQLTest.Controllers {
    [Route("home")]
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly SqlManager<MySqlTestConnection> _sqlManager;

        public HomeController(ILogger<HomeController> logger, SqlManager<MySqlTestConnection> sqlManager) =>
            (_logger, _sqlManager) = (logger, sqlManager);

        [HttpGet("")]
        public IActionResult Index() => View();

        [HttpGet("Privacy")]
        public IActionResult Privacy() => View();

        [HttpGet("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
