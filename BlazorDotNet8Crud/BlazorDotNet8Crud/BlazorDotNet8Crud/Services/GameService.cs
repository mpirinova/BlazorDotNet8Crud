using BlazorDotNet8Crud.Data;
using BlazorDotNet8Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDotNet8Crud.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext dbContext;

        public GameService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Game> AddGame(Game game)
        {
            this.dbContext.Games.Add(game);
            await this.dbContext.SaveChangesAsync();

            return game;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await this.dbContext.Games.ToListAsync();
        }
    }
}
