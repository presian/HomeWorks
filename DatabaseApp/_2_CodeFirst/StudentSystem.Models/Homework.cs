namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public HomeworkContentType HomeworkContentType { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
