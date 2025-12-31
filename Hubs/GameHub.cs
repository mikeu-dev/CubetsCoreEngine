using cubets_core.Modules.GameState.Models;
using Microsoft.AspNetCore.SignalR;

namespace cubets_core.Hubs
{
    public class GameHub : Hub<IGameClient>
    {
        public async Task SendPlayerState(PlayerState state)
        {
            await Clients.Others.ReceivePlayerState(state);
        }
    }
}
