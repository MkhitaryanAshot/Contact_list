namespace Contact_list.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int AddresId { get; set; }
        public Address Address { get; set; }


    }
}
