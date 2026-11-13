using System.ComponentModel.DataAnnotations;

namespace University_DbApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Аты-жөнін енгізу міндетті")]
        public string FullName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Кафедра")]
        public int DepartmentId { get; set; }

        // Мәселені шешетін маңызды жер: соңына сұрақ белгісі (?) қойылады
        public Department? Department { get; set; }
    }
}