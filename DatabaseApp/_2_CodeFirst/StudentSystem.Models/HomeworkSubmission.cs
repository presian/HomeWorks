namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class HomeworkSubmission
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Required]
        public int HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }

        [Required]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
