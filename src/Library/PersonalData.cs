namespace Library
{
    public class PersonalData
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private Address Address { get; set; }
        private ContactInfo ContactInfo { get; set; }
        
        public PersonalData(string name, string lastname, string phone, string email, Address address, ContactInfo contactinfo)
        {
            Name = name;
            LastName = lastname;
            Address = address;
            ContactInfo = contactinfo;
        }
    }
}