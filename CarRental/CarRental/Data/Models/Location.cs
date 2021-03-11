using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data.Models
{
    public class Location
    {
        public Location()
        {
            this.ReservationInfosForReturnLocations = new HashSet<ReservationInfo>();
            this.ReservationInfosForPickUpLocations = new HashSet<ReservationInfo>();
        }

        [Key]
        public int Id { get; set; }



        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Country { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Town { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string District { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Street { get; set; }


        public int? Number { get; set; }


        [InverseProperty("ReturnLocation")]
        public virtual ICollection<ReservationInfo> ReservationInfosForReturnLocations { get; set; }

        [InverseProperty("PickUpLocation")]
        public virtual ICollection<ReservationInfo> ReservationInfosForPickUpLocations { get; set; }





    }
}
