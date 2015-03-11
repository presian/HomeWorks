namespace NewsSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        [ConcurrencyCheck]
        public string Content { get; set; }
    }
}
