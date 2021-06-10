namespace Models
{
    using System.ComponentModel.DataAnnotations;

    public class GameExtra
    {
        [Required]
        public int GameId { get; set; }
        [Required]
        public int ExtraId { get; set; }
        public Game Game { get; set; }
        public Extra Extra { get; set; }
    }
}
