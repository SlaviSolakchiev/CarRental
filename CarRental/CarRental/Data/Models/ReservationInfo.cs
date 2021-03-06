using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data.Models
{
    public class ReservationInfo
    {

        [Key]
        public int Id { get; set; }



        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }




        [Required]
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }



        [Required]
        public DateTime PickUpDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }




        [Required]
        [ForeignKey(nameof(PickUpLocation))]
        public int PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }




        [Required]
        [ForeignKey(nameof(ReturnLocation))]
        public int ReturnLocationId { get; set; }
        public Location ReturnLocation { get; set; }
    }
}
