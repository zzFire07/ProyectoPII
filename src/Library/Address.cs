namespace Library
{
    public class Address
    {
        private string Street { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Country { get; set; }
        private string PostalCode { get; set; }

        public Address(string street, string city, string state, string country, string postalcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalcode;
        }
    }
}