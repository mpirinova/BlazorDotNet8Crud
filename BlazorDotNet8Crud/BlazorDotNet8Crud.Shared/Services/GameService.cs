using BlazorDotNet8Crud.Shared.Data;
using BlazorDotNet8Crud.Shared.Entities;
using BlazorDotNet8Crud.Shared.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlazorDotNet8Crud.Shared.Services
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

        public async Task<bool> DeleteGame(int id)
        {
            var game = await this.dbContext.Games.FindAsync(id);
            if (game is not null)
            {
                this.dbContext.Remove(game);
                await this.dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var dbGame = await this.dbContext.Games.FindAsync(id);
            if (dbGame is not null)
            {
                dbGame.Name = game.Name;
                await this.dbContext.SaveChangesAsync();
                return dbGame;
            }
            throw new Exception("Game not found!");
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await this.dbContext.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            return await this.dbContext.Games.FindAsync(id);
        }
    }
}
