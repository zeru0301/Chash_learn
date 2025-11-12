using Microsoft.EntityFrameworkCore;
using energyEC.Models;

namespace energyEC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistory { get; set; }

        public DbSet<InquiryHistory> InquiryHistory {  get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product"); // DBのテーブル名
                entity.Property(e => e.ProductId).HasColumnName("product_id");
                entity.Property(e => e.ProductName).HasColumnName("product_name");
                entity.Property(e => e.ProductPrice).HasColumnName("product_price");
                entity.Property(e => e.ProductDescription).HasColumnName("product_description");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.ProductImages).HasColumnName("product_images");

            });

            modelBuilder.Entity<PurchaseHistory>(entity =>
            {
                entity.ToTable("purchase_history");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.ProductName).HasColumnName("product_name");
                entity.Property(e => e.ProductPieces).HasColumnName("product_pieces");
                entity.Property(e => e.HistoryTimestamp).HasColumnName("history_timestamp");
            });
        }
    }
}
