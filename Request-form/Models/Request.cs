using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Request_form.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string RequestNote { get; set; }
        [Required]
        public string Address { get; set; }
       
        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }
    }
}