

namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
