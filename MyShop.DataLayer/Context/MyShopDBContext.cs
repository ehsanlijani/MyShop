using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Entities.Products;

namespace MyShop.DataLayer.Context;

public class MyShopDBContext : DbContext
{
    public MyShopDBContext(DbContextOptions<MyShopDBContext> options) : base(options) {}
    public DbSet<Product> products{ get; set; }
    public DbSet<ProductCategory> productCategories { get; set; }
}
