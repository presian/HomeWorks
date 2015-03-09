namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public ResourceType ResourceType { get; set; }

        [Required]
        [MinLength(5)]
        public string Link { get; set; }
    }
}
