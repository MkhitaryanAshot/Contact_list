using Contact_list.Domain.Entities;
using Contact_list.DAL.Interfaces;
using System;
using System.Linq;
using Contact_list.DAL.DataAccess;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace Contact_list.DAL.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly AppliactionDBContext _dbcontext;
        private readonly IAddressrepository _addressrepository;

        public ContactsRepository(AppliactionDBContext appdbcont, IAddressrepository addressrepository)
        {
            _dbcontext = appdbcont;
            _addressrepository = addressrepository;
        }

        public List<Contact> Get()
        {

            return _dbcontext.Contacts.Include(c => c.Address).ToList(); 
        }

        public async Task<Contact> GetById(int id)
        {
            var contact = await _dbcontext.Contacts.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == id); 

            if (contact == null)
            {
                throw new Exception();
            }
            return contact;
        }
        public async Task CreateAsync(Contact cont)
        {
            var contact = new Contact
            {
                FirstName = cont.FirstName,
                LastName = cont.LastName,
                Phone = cont.Phone,
                Email = cont.Email
            };


            var address = await _addressrepository.GetDuplication(cont.Address);

            if (address == null)
            {
                var createdaddress = await _addressrepository.CreateAsync(cont.Address);
               
                contact.AddressId = createdaddress.Id;
            }
            else
            {
                contact.AddressId = address.Id;
            }

            _dbcontext.Contacts.Add(contact);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task EditAsync(Contact cont)
        {
            var contact = _dbcontext.Contacts.FirstOrDefault(c => c.Id == cont.Id);
            if (contact == null)
            {
                //TODO needs exception
                return;
            }

            contact.FirstName = cont.FirstName;
            contact.LastName = cont.LastName;
            contact.Phone = cont.Phone;
            contact.Email = cont.Email;


            var address = await _addressrepository.GetDuplication(cont.Address);

            if (address == null)
            {
                var createdaddress = _addressrepository.CreateAsync(cont.Address);
                await _dbcontext.SaveChangesAsync();
                contact.AddressId = createdaddress.Id;
            }
            else
            {
                contact.AddressId = address.Id;
            }

            _dbcontext.Contacts.Attach(contact);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task RemoveAsync(int contactId)
        {
            var contact = _dbcontext.Contacts.FirstOrDefault(c => c.Id == contactId);
            if (contact == null)
            {
                return;
            }
            _dbcontext.Contacts.Remove(contact);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
