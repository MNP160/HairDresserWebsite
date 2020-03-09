using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresser.Models
{
    public class Client
    {
        [Key]

        public int Id { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public virtual ICollection<Reservation> Reservations{get; set;}

    }
}
