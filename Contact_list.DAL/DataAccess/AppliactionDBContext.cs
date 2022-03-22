using Contact_list.Domain.Entities;
using System.Data.Entity;

namespace Contact_list.DAL.DataAccess
{
    public class AppliactionDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public AppliactionDBContext() : base("name=Contactinfo")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
