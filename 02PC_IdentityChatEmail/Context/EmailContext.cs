using _02PC_IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _02PC_IdentityChatEmail.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SG606F1\\SQLEXPRESS;Initial Catalog=02PC_IdentityChatEmailDb;Integrated Security=true;Trust Server Certificate=true");
        }

        public DbSet<Message> Messages { get; set; }
    }
}
