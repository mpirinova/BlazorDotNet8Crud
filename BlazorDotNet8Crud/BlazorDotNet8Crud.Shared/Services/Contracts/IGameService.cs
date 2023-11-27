using BlazorDotNet8Crud.Shared.Entities;

namespace BlazorDotNet8Crud.Shared.Services.Contracts
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();

        Task<Game> AddGame(Game game);
    }
}
