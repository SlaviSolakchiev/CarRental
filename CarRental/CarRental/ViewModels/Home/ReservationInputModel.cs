using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Home
{
    public class ReservationInputModel
    {
        public ReservationInputModel()
        {
            //this.CarItems = new List<Car>();
        }



        [Required]
        public string UserName { get; set; }

        public string UserId { get; set; }


        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string TelephoneNumber { get; set; }


        [Required]
        public DateTime PickUpDate { get; set; }


        [Required]
        public DateTime ReturnDate { get; set; }


        [Required]
        public string CarId { get; set; }



        [Required]
        public string PickUpLocation { get; set; }


        [Required]
        public string ReturnLocation { get; set; }
    }
}
