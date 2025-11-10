using cubets_core.Modules.GameState.Models;
using Microsoft.AspNetCore.SignalR;

namespace cubets_core.Hubs
{
    public class GameHub: Hub
    {
        public async Task SendPlayerState(PlayerState state)
        {
            await Clients.Others.SendAsync("ReceivePlayerState", state);
        }
    }
}
