using Microsoft.EntityFrameworkCore;

namespace cubets_core.Modules.Score.Services
{
    public class ScoreService
    {
        private readonly Data.CubetsDbContext _dbContext;
        public ScoreService(Data.CubetsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddScoreAsync(int playerId, int score)
        {
            var scoreEntry = new Models.ScoreEntry
            {
                PlayerId = playerId,
                Score = score,
                AchievedAt = DateTime.UtcNow
            };
            _dbContext.ScoreEntries.Add(scoreEntry);

            var player = await _dbContext.Players.FindAsync(playerId);
            if (player != null && score > player.HighScore) {
                player.HighScore = score;
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Models.ScoreEntry>> GetTopScoresAsync(int topN)
        {
            return await _dbContext.ScoreEntries
                .OrderByDescending(se => se.Score)
                .Take(topN)
                .ToListAsync();
        }
    }
}
