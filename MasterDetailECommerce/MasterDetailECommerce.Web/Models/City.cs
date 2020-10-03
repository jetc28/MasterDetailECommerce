using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDetailECommerce.Web.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characters length")]
        [Display(Name = "City")]
        public string Name { get; set; }

        [ForeignKey("Departament")]
        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1,double.MaxValue, ErrorMessage ="You must select a {0}")]
        public int DepartamentId{ get; set; }

        public virtual Departament Departament { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
