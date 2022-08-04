using Estagios.Data;
using Estagios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estagios.Controllers
{
    public class EstagioController : Controller
    {
        private readonly ILogger<EstagioController> _logger;
        private readonly DataContext _context;

        public EstagioController(ILogger<EstagioController> logger, DataContext dataContext)
        {
            _logger = logger;
            _context = dataContext;
        }

        // GET All Estagios /Estagio/Index
        public IActionResult Index()
        {
            return View();
        }

        // Get one Estagio /Estagio/Get/{id}
        public IActionResult Get(int id)
        {
            if(id == default(int))
            {
                return NotFound();
            }

            var estagio = _context.Estagios.FirstOrDefault(e => e.Id == id);

            if(estagio == null)
            {
                return NotFound();
            }

            return View(estagio);
        }

        // Post new Estagio /Estagio/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}