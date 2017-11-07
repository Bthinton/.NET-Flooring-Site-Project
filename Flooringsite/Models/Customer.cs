using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Flooringsite.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name may not exceed 50 charaters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name may not exceed 50 charaters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "Email Address may not exceed 50 charaters.")]
        [Display(Name = "Customer Email")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(11, ErrorMessage = "Contact number may not exceed 11 characters.")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Requested")]
        public DateTime RequestedDate { get; set; }
    }
}