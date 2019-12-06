using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email")]
        [RegularExpression(".+\\@.+\\..+",
ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please choose the option")]
        public bool? WillAttend { get; set; }
    }
}
