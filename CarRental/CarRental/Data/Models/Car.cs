using CarRental.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string Brand { get; set; }


        [Required]
        [MaxLength(80)]
        [MinLength(1)]
        public string Model { get; set; }

        [Required]
        [Range(1990, 2021)]
        public int Year { get; set; }



        public double? FuelConpsumption { get; set; }



        public double? PriceForDay { get; set; }


        [Required]
        public double RealPrice { get; set; }


        [Required]
        public double KilometersTraveled { get; set; }


        [Required]
        public bool Rented { get; set; }



        public Categories Category { get; set; }

    }
}
