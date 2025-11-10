namespace cubets_core.Modules.Auth.DTOs
{
    public class PlayerDTO
    {
        public string Name { get; set; } = string.Empty;
        public int Highscore { get; set; } = 0;

        public int Lowscore { get; set;} = 0;
    }
}
