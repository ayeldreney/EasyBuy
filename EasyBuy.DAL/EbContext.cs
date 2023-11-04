using EasyBuy.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy.DAL;
public class EbContext:IdentityDbContext
{
	public DbSet<Product> Products { get; set; }

	public EbContext(DbContextOptions<EbContext> options):base(options) {}
}