namespace Library
{
    public class PersonalData
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        Address address = new Address();
        
        public PersonalData(string name, string lastname, string phone, string email, Address address)
        {
            Name = name;
            LastName = lastname;
            Phone = phone;
            Email = email;
            Address = address;
        }
    }
}