using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
	[Table("Users")]
	public class User
	{
		[Key]
		[Required]
		public Guid Id { get; set; }

		[StringLength(50)]
		[Required]
		public string Login { get; set; }

		[StringLength(50)]
		[Required]
		public string Email { get; set; }
	}
}
