using GraphApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.Graph;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GraphApi.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly ITokenAcquisition tokenAcquisition;

        private readonly GraphServiceClient _graphServiceClient;

        public HomeController(ILogger<HomeController> logger, ITokenAcquisition tokenAcquisition, GraphServiceClient graphServiceClient)
        {
            _logger = logger;
            this.tokenAcquisition = tokenAcquisition;
            this._graphServiceClient = graphServiceClient;

        }

        public async Task<IActionResult> Index()
        {

            var user = await _graphServiceClient.Me.Request().GetAsync();
            ViewBag.username = user.DisplayName;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
