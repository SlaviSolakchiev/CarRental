using CarRental.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data
{
    public class ApplicationUser : IdentityUser
    {

        public int? Age { get; set; }


        [Required]
        [ForeignKey(nameof(ReservationInfo))]
        public int ReservationInfoId { get; set; }
        public virtual ReservationInfo ReservationInfo { get; set; }

    }
}
