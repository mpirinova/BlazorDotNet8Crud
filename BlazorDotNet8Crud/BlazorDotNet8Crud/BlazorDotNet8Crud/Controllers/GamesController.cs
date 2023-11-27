using BlazorDotNet8Crud.Shared.Entities;
using BlazorDotNet8Crud.Shared.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDotNet8Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService gameService;

        public GamesController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var newGame = await this.gameService.AddGame(game);
            return Ok(newGame);
        }
    }
}
