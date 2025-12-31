using cubets_core.Modules.GameState.Models;
using System.Threading.Tasks;

namespace cubets_core.Hubs
{
    public interface IGameClient
    {
        Task ReceivePlayerState(PlayerState state);
    }
}
