using System.ComponentModel.DataAnnotations.Schema;

namespace GoatUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; } = null!;
        public int Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
