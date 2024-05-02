using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySystem.DAL.Model
{
    public class Sponsors
    {
        [Key]
        public int SponsID { get; set; }

        public string SponsorName_Ar { get; set; }
        public string SponsorName { get; set; }

        public string Location_Ar { get; set; }
        public string Location { get; set; }

        public int Email { get; set; }

        public string Comments_Ar { get; set; }
        public string Comments { get; set; }

        public int PhoneNo { get; set; }

        public string AddBy { get; set; } = "Admin";
        public string UpdateBy { get; set; } = "Admin";

        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
