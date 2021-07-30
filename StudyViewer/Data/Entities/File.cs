using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
	[Table("Users")]
	public class File
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		[Key]
		[Required]
		public Guid Id { get; set; }

		/// <summary>
		/// Имя файла
		/// </summary>
		[StringLength(250)]
		[Required]
		public string FileName { get; set; }

		/// <summary>
		/// Путь к файлу
		/// </summary>
		[StringLength(500)]
		[Required]
		public string FilePath { get; set; }

		/// <summary>
		/// Дата создания
		/// </summary>
		[Required]
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Кем было создано создание/изменение
		/// </summary>
		[Required]
		[ForeignKey("User")]
		public Guid ChangedBy { get; set; }

		/// <summary>
		/// Дата последнего обновления
		/// </summary>
		public DateTime LastChangedDate { get; set; }

		public User User { get; set; }
	}
}
