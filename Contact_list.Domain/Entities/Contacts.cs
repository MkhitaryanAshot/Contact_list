using System.ComponentModel.DataAnnotations;

namespace Contact_list.Domain.Entities
{
    public class Contact
    {


        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string firstName, string lastName, string email, string phone, int addressId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            AddressId = addressId;
        }


       
    }
}
