using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySystem.DAL.Model
{
   public  class Event
    {

        [Key]
        public int EventID { get; set; }

        public string Title_Ar { get; set; }
        public string Title { get; set; }

        public string Description_Ar { get; set; }
        public string Description { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public byte[]? Image { get; set; }

        public string? Status { get; set; }

        public string Place_Ar { get; set; }
        public string Place { get; set; }

        public string? Comments_Ar { get; set; }
        public string? Comments { get; set; }

        public string? Goal_Ar { get; set; }
        public string? Goal { get; set; }

        public string EventType_Ar { get; set; }
        public string EventType { get; set; }

        public string AddBy { get; set; } = "Admin";
        public string UpdateBy { get; set; } = "Admin";

        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public DateTime AddDate { get; set; } = DateTime.Now;

        [ForeignKey("Groups")]
        public int GroupId { get; set; }
        public Groups Groups { get; set; }
    }

}

