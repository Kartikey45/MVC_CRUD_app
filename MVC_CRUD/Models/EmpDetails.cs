using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class EmpDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter employee name")]
        [Display(Name = "Employee name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter employee email")]
        [Display(Name = "Employee email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter employee age")]
        [Display(Name = "Employee age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter employee salary")]
        [Display(Name = "Employee salary")]
        public int Salary { get; set; }
    }
}
