using cubets_core.Data;
using cubets_core.Modules.Player.DTOs;

namespace cubets_core.Modules.Player.Services
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
                Name = player.Nickname, 
                Highscore = player.HighScore, 
                Lowscore = player.LowScore
            };
        }
    }
}
