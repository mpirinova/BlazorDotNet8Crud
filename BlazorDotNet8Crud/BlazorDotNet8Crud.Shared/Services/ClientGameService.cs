using BlazorDotNet8Crud.Shared.Entities;
using BlazorDotNet8Crud.Shared.Services.Contracts;
using System.Net.Http.Json;

namespace BlazorDotNet8Crud.Shared.Services
{
    public class ClientGameService : IGameService
    {
        private readonly HttpClient httpClient;

        public ClientGameService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Game> AddGame(Game game)
        {
            var result = await this.httpClient.PostAsJsonAsync("api/games", game);
            var test = await result.Content.ReadFromJsonAsync<Game>();
            return test;
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
