using CarRental.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Home
{
    public class IndexViewModel
    {

        [Required]
        public string UserName { get; set; }


        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string TelephoneNumber { get; set; }




        [Required]
        //[BindProperty, DataType(DataType.Date)]
        public DateTime PickUpDate { get; set; }

        [Required]        
        //[BindProperty, DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }




        //[Required]
        //[BindProperty, DataType(DataType.Time)]
        //public DateTime PickUpTime { get; set; }

        //[Required]
        //[BindProperty, DataType(DataType.Time)]
        //public DateTime ReturnTime { get; set; }
        //[Required]

 




        public string Car { get; set; }

        public List<SelectListItem> CarItems { get; set; }





        public List<SelectListItem> LocationItems { get; set; }

        [Required]
        public string PickUpLocation { get; set; }


        [Required]
        public string ReturnLocation { get; set; }


    }
}
