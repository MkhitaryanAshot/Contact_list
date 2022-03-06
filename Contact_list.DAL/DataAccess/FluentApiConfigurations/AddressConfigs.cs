using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Contact_list.Domain.Entities;

namespace Contact_list.DAL.FluentApiConfigurations
{
    public class AddressConfigs:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.
                HasKey(c => c.Id);

            builder
                .HasMany(c => c.Contacts)
                .WithOne(a => a.Address)
                .HasForeignKey(c => c.AddresId);

        }
    }
}
