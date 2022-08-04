using Microsoft.AspNetCore.Mvc;

namespace Estagios.Controllers
{
    public class EstagioController : Controller
    {
        private readonly ILogger<EstagioController> _logger;

        public EstagioController(ILogger<EstagioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}