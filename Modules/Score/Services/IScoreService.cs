using cubets_core.Modules.Score.DTOs;

namespace cubets_core.Modules.Score.Services
{
    public interface IScoreService
    {
        Task<List<ScoreEntryDto>> GetTopScoresAsync(int playerId);
    }
}
