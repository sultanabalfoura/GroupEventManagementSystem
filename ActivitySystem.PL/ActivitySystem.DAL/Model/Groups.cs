using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;

namespace ActivitySystem.DAL.Model
{
	public class Groups
	{
		[Key]
		public int GroupID { get; set; }

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

        public byte[]? Image { get; set; }

        [Required]
        public bool Active { get; set; }

        [MinLength(2)]
        public string AddedBy { get; set; } = "Admin";

        [MinLength(2)]
        public string UpdatedBy { get; set; } = "Admin";

        [DataType(DataType.Date)]
		public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public ICollection<Members> Members { get; set; }
		public ICollection<GroupPosition> GroupPositions { get; set; }

	}
}

