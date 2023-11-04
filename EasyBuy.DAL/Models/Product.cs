using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy.DAL.Models;
public class Product
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Required, MaxLength(255)]
	public string Name { get; set; } = string.Empty;
}