using cubets_core.Common;
using cubets_core.Modules.Player.DTOs;
using cubets_core.Modules.Score.DTOs;
using cubets_core.Modules.Score.Services;
using Microsoft.AspNetCore.Mvc;

namespace cubets_core.Modules.Score.Controllers
{
    [ApiController]
    [Route("api/score")]
    public class ScoreController: ControllerBase
    {
        private readonly IResponseService _response;
        private readonly IScoreService _scoreService;

        public ScoreController(IScoreService scoreService, IResponseService response) 
        {
            _response = response;
            _scoreService = scoreService; 
        }

        [HttpGet("{playerId}")]
        public ActionResult<ScoreEntryDto> GetTopScores(int playerId)
        {
            var result = _scoreService.GetTopScoresAsync(playerId);
            if (result == null) return NotFound(_response.Fail<object>("Top Score Not Found!"));

            return Ok(_response.Success(result, "Get Top Scores Successful!"));
        }
    }
}
