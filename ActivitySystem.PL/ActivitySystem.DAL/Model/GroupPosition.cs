using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivitySystem.DAL.Model
{
	public class GroupPosition
	{
		[Key]
		public int positionID { get; set; }

		public string Title { get; set; }
		public string Title_Ar { get; set; }

        [MinLength(2)]
        public string AddedBy { get; set; }

        [MinLength(2)]
        public string UpdatedBy { get; set; }
        [MinLength(2)]

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [ForeignKey("Members")]
		public int MemberID { get; set; }

		public Members Member { get; set; }
	}
}

