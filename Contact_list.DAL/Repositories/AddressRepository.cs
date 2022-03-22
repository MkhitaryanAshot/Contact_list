using Contact_list.DAL.Interfaces;
using Contact_list.Domain.Entities;
using System.Data.Entity;
using System.Threading.Tasks;
using Contact_list.DAL.DataAccess;

namespace Contact_list.DAL.Repositories
{
    public class AddressRepository : IAddressrepository
    {
        AppliactionDBContext _dbcontext;
        public AddressRepository(AppliactionDBContext context)
        {
            _dbcontext = context;
        }
        public async Task< Address> CreateAsync(Address address)
        {
            var created = _dbcontext.Addresses.Add(address);
            await _dbcontext.SaveChangesAsync();
            return created;
        }

        public async Task<Address> GetById(int id)
        {
            return await _dbcontext.Addresses.FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task<Address> GetDuplication(Address address)
        {
            return  await _dbcontext.Addresses.FirstOrDefaultAsync(
                          c => c.Country == address.Country &&
                          c.City == address.City &&
                          c.Street == address.Street &&
                          c.Building == address.Building
                     );
        }
    }
}
