using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivitySystem.DAL.Model
{
	public class MemberShip
	{
		public int membershipID { get; set; }

        [ForeignKey("Members")]
        public int MemberID { set; get; }
        public Members Member { set; get; }

        [ForeignKey("Groups")]
        public int GroupID { set; get; }
        public Groups Group { set; get; }

    }
}

