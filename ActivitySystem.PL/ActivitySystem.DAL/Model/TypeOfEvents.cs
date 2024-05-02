using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySystem.DAL.Model
{
    public class TypeOfEvents
    {
        [Key]
        public int TypeOfEventID { get; set; }

        public string Title_Ar { get; set; }
        public string Title { get; set; }

        public string AddBy { get; set; } = "Admin";
        public string UpdateBy { get; set; } = "Admin";

        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
