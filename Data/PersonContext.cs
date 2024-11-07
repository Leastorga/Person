using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data
{
    public class PersonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<PersonModel> People { get; set; }


    }
}
