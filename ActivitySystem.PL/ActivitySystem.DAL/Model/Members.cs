using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivitySystem.DAL.Model
{
	public class Members
	{
		[Key]
		public int MemberId { get; set; }

        [MinLength(3)]
        public string FullName { get; set; }
        [MinLength(2)]
        public string FullName_Ar { get; set; }

        [DataType(DataType.EmailAddress)]
		public string Email { get; set; }

        //public string AcademyYear { get; set; }

        [DataType(DataType.PhoneNumber)]
		public string PhoneNo { get; set; }

        [MinLength(3)]
        public string AddedBy { get; set; }

        [MinLength(3)]
        public string UpdatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public ICollection<Groups> Groups { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; }


    }
}

