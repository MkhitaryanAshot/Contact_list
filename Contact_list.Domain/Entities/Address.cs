namespace Contact_list.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Appartament { get; set; }
        public List<Contact> Contacts { get; set; }


    }
}
