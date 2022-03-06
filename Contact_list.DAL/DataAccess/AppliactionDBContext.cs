using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Contact_list.DAL.FluentApiConfigurations;
using Contact_list.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Contact_list.DAL.DataAccess
{
    public class AppliactionDBContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public AppliactionDBContext(DbContextOptions<AppliactionDBContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ContactsConfigs());
        }

        
    }
}
