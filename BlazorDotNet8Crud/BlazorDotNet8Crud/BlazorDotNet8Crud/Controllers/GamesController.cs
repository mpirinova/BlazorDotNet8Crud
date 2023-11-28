using BlazorDotNet8Crud.Shared.Entities;
using BlazorDotNet8Crud.Shared.Services.Contracts;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            return Ok(await this.gameService.GetGameById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var newGame = await this.gameService.AddGame(game);
            return Ok(newGame);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Game>> EditGame(int id, Game game)
        {
            var updated = await this.gameService.EditGame(id, game);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteGame(int id)
        {
            var isDeleted = await this.gameService.DeleteGame(id);
            return Ok(isDeleted);
        }
    }
}
