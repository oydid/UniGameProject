namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Extra
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<GameExtra> GameExtras { get; set; }
    }
}
