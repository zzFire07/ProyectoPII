namespace Library
{
    public class Employer : IUser
    {
        private PersonalData EmployerPersonalData { get; set; }
        private ContactInfo EmployerContactInfo { get; set; }

        public Employer(PersonalData personalData, ContactInfo contactInfo)
        {
            this.EmployerPersonalData = personalData;
            this.EmployerContactInfo = contactInfo;
        }
        private void ContactEmployee(ContactInfo employeeinfo)
        {
            // Contact employer
        }
    }
}