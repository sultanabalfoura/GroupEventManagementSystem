using System;
using System.ComponentModel.DataAnnotations;

namespace ActivitySystem.PL.Models
{
	public class GroupsVM
	{
        [Required]
        [MinLength(2)]
        public string GroupName { get; set; }

        [Required]
        [MinLength(2)]
        public string GroupName_Ar { get; set; }

        public int GroupReference { get; set; } = 1;

        [Required]
        public string Discription { get; set; }
        [Required]
        public string Discription_Ar { get; set; }

        public byte[] Image { get; set; }

        public IFormFile ImageFile { get; set; }

        [Required]
        public bool Active { get; set; }

    }
}

