using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace University_DbApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Кафедра аты міндетті түрде көрсетілуі тиіс")]
        [Display(Name = "Кафедра атауы")]
        public string Name { get; set; }

        [Display(Name = "Корпус / Бөлме")]
        public string Location { get; set; } // Ерекшелік үшін қосылды

        public ICollection<Teacher> Teachers { get; set; }
    }
}