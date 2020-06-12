using JwtExample.Domain.Interfaces;
using JwtExample.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JwtExample.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HomeController : Controller
    {
        private readonly ITokenService _tokenService;

        public HomeController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("GenerateToken")]
        public ActionResult<dynamic> GenerateToken(string username, string password)
        {
            var user = UserRepository.Get(username, password);

            if (user == null)
                return NotFound(new { message =  $"Usuario {username} não encontrado"});

            var token = _tokenService.GenerateToken(user);

            return Ok("Bearer " + token);
        }
    }
}
