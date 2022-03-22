using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Default Number Of Days")]
        [Required]
        [Range(1,30,ErrorMessage ="Please input no. between 1 and 30")]
        public int DefaultDays { get; set; }
    }
}
