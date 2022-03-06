using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Contact_list.Domain.Entities;

namespace Contact_list.DAL.FluentApiConfigurations
{
    public class ContactsConfigs : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder
                 .HasKey(c => c.Id);

            builder
                .Property(c => c.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(c => c.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Email).IsRequired();
            
            builder.Property(c => c.Phone).IsRequired();
            builder
                .HasOne(c => c.Address)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.AddresId);
        }
    }
}
