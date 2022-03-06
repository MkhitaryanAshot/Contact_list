using Contact_list.Domain.Entities;

namespace Contact_list.DAL.Interfaces
{
    public interface IContactsRepository
    {
       Task CreateAsync(Contact cont);
       Task EditAsync(Contact cont);
       Task RemoveAsync(int contactId);
       List<Contact> Get();
       Task<Contact> GetById(int id);
    }
}
