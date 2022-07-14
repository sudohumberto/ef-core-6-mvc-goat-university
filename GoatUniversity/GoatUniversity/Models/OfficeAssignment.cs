using System.ComponentModel.DataAnnotations;

namespace GoatUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; } = null!;

        public Instructor Instructor { get; set; } = null!;
    }
}
