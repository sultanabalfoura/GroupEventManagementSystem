using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySystem.DAL.Model
{
    public class SponsorShip
    {
        [Key]
        public int SponsorshipID { get; set; }

        public double Amount { get; set; }

        public string AddBy { get; set; } = "Admin";
        public string UpdateBy { get; set; } = "Admin";

        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public DateTime AddDate { get; set; } = DateTime.Now;

        [ForeignKey("Sponsors")]
        public int SponsorId { get; set; }
        public Sponsors Sponsors { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
