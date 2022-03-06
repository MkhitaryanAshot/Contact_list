using AutoMapper;
using Contact_list.Domain.Entities;
using Contact_list.Models;

namespace Contact_list.AutoMapperConfigs
{
    public class ContactListProfile : Profile
    {
        public ContactListProfile()
        {
            CreateMap<Contact, ContactViewModel>();
            CreateMap<ContactViewModel, Contact>();

            CreateMap<Address, AddressViewModel>();
            CreateMap<AddressViewModel, Address>();
        }
    }
}
