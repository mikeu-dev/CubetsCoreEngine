using cubets_core.Modules.Auth.DTOs;
using cubets_core.Modules.Auth.Services;
using Microsoft.AspNetCore.Mvc;

namespace cubets_core.Modules.Auth.Controllers
{
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService) => _playerService = playerService;

        [HttpGet("{id}")]
        public ActionResult<PlayerDTO> GetPlayer(int id)
        {
            var playerDto = _playerService.GetPlayerDto(id);
            if (playerDto == null) return NotFound();

            return Ok(playerDto);

        }
    }
}
