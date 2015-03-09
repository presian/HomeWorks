namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<HomeworkSubmission> submissions;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.submissions = new HashSet<HomeworkSubmission>();
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<HomeworkSubmission> Submissions
        {
            get { return this.submissions; }
            set { this.submissions = value; }
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }
        
        [Required]
        public DateTime BirthDay { get; set; }
    }
}
