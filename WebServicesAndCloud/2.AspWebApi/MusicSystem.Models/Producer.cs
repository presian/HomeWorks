namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}