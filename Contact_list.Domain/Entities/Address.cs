using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contact_list.Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Appartament { get; set; }
        public List<Contact> Contacts { get; set; }


    }
}
