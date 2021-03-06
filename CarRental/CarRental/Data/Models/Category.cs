using CarRental.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Cars = new HashSet<Car>();
        }

        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public CategoriesNames CategoryName { get; set; }


        public virtual ICollection<Car> Cars { get; set; }
    }
}
