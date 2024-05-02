using System;
using System.ComponentModel.DataAnnotations;

namespace ActivitySystem.PL.Models
{
	public class MembersVM
	{
        public int MemberId { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        //public string CollegeName { get; set; }

        //public string AcademyYear { get; set; }

    }
}

