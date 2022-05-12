using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP_NET_Video_Games_API.Data;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VideoGamesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllVideoGames()
        {
            var allVideoGames = _context.VideoGames;
            return Ok(allVideoGames);
        }
        [HttpGet("{Id}")]
        public IActionResult GetGamesbyId(int Id)
        {
            var gameId = _context.VideoGames.Where(vg => vg.Id == Id);
            return Ok(gameId);
        }

    }
}
