using Estagios.Data;
using Estagios.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Estagios.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }
        
        // GET Login page /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] UserDto userDto)
        {
            var user = _context.Users.SingleOrDefault(x => x.Username == userDto.Username);

            if (user == null)
                return Unauthorized();

            if (user.Password != userDto.Password)
                return Unauthorized();

            return RedirectToAction("Index", "Estagio", new { area = ""} );
        }
    }
}
