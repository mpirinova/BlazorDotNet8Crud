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
            var result = await this.httpClient.PostAsJsonAsync("/api/games", game);
            var test = await result.Content.ReadFromJsonAsync<Game>();
            return test;
        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await this.httpClient.DeleteAsync($"/api/game/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var result = await this.httpClient.PutAsJsonAsync($"/api/game/{id}", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public async Task<Game> GetGameById(int id)
        {
            return await this.httpClient.GetFromJsonAsync<Game>($"/api/games/{id}");
        }
    }
}
