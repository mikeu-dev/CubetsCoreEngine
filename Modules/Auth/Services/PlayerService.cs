using cubets_core.Data;
using cubets_core.Modules.Auth.DTOs;

namespace cubets_core.Modules.Auth.Services
{
    public class PlayerService
    {
        private readonly CubetsDbContext _dbContext;
        public PlayerService(CubetsDbContext dbContext) => _dbContext = dbContext;

        public PlayerDTO? GetPlayerDto(int Id)
        {
            var player = _dbContext.Players.Find(Id);
            if (player == null) return null!;
            return new PlayerDTO {
                Name = player.Name, 
                Highscore = player.HighScore, 
                Lowscore = player.LowScore
            };
        }
    }
}
