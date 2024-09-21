using Microsoft.EntityFrameworkCore;
using VerifyEmailForgetPassword.Models;

namespace VerifyEmailForgetPassword.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EmailSenderVerify;User Id=postgres;Password=sulton;");
        }



        public DbSet<User> Users { get; set; }
    }
}
