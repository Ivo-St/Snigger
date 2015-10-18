using System.ComponentModel.DataAnnotations;

namespace Snigger.Models
{
    public class Snicker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; }

        [Required]
        [MinLength (1)]
        [MaxLength (140)]
        public string Message { get; set; }
    }
}
