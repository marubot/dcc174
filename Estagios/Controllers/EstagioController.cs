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
        public ActionResult<IEnumerable<Estagio>> Index()
        {
            var estagios = _context.Estagios.ToList();
            
            if(estagios == null)
                return NotFound();
            
            return View(estagios);
        }

        // Get one Estagio /Estagio/Get/{id}
        public IActionResult Get(int id)
        {
            if(id == default(int))
                return NotFound();

            var estagio = _context.Estagios.FirstOrDefault(e => e.Id == id);

            if(estagio == null)
                return NotFound();

            return View(estagio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // Post new Estagio /Estagio/Create
        public IActionResult Create(Estagio estagio)
        {
            if (estagio == null)
                throw new ArgumentNullException(nameof(estagio));

                _context.Estagios.Add(estagio);

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
        }
    }
}