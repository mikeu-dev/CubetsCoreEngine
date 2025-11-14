using cubets_core.Common;
using cubets_core.Modules.Player.DTOs;
using cubets_core.Modules.Player.Services;
using Microsoft.AspNetCore.Mvc;

namespace cubets_core.Modules.Player.Controllers
{
    [ApiController]
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly IResponseService _response;
        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService, IResponseService response)
        {
            _response = response;
            _playerService = playerService;
        }

        [HttpGet("{playerId}")]
        public ActionResult<PlayerDTO> GetPlayer(int playerId)
        {
            var playerDto = _playerService.GetPlayerDto(playerId);
            if (playerDto == null) return NotFound(_response.Fail<object>("Player Not Found!"));

            return Ok(_response.Success(playerDto, "Get Player Data Is Successful!"));

        }
    }
}
