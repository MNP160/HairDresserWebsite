using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresser.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public DateTime ReservationDate { get; set; }



        [ForeignKey("Client")]
        public virtual int ClientId {get; set;}
        public virtual Client Client { get; set; }


    }
}
