using BlazorDotNet8Crud.Entities;

namespace BlazorDotNet8Crud.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();

        Task<Game> AddGame(Game game);
    }
}
