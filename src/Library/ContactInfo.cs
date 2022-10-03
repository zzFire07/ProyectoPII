namespace Library
{
    public class ContactInfo
    {
        private string Email { get; set; }
        private string Phone { get; set; }

        public ContactInfo(string email, string phone, Address address)
        {
            Email = email;
            Phone = phone;
        }
    }
}