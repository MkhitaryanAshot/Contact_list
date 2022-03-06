using Contact_list.DAL.Interfaces;
using Contact_list.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_list.DAL.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Contact_list.DAL.Repositories
{
    public class AddressRepository : IAddressrepository
    {
        AppliactionDBContext _dbcontext;
        public AddressRepository(AppliactionDBContext context)
        {
            _dbcontext = context;
        }
        public Address CreateAsync(Address address)
        {
            var created = _dbcontext.Addresses.Add(address);
            return created.Entity;
        }

        public async Task<Address> GetById(int id)
        {
            return await _dbcontext.Addresses.FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task<Address?> GetDuplication(Address address)
        {
            return await _dbcontext.Addresses.FirstOrDefaultAsync(
                          c => c.Country == address.Country &&
                          c.City == address.City &&
                          c.Street == address.Street &&
                          c.Building == address.Building
      );
        }
    }
}
