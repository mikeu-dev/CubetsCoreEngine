using cubets_core.Modules.Auth.Models;

namespace cubets_core.Modules.Player.Models
{
    public class Player
    {
        public int Id { get; set; }

        // foreign key ke User
        public int? UserId { get; set; }
        public User? User { get; set; }

        public string Nickname { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int Coins { get; set; } = 0;
        public int HighScore { get; set; }
        public int LowScore { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
