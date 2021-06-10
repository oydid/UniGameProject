namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int YearReleased { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<GameExtra> GameExtras { get; set; }
    }
}
