using Contact_list.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list.DAL.Interfaces
{
    public interface IAddressrepository
    {

        Task<Address> CreateAsync(Address cont);
        Task<Address> GetDuplication(Address address);
    }
}
