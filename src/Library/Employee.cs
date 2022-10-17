namespace Library;
public class Employee : IUser
{
    private PersonalData EmployeePersonalData { get; set; }
    private ContactInfo EmployeeContactInfo { get; set; }
    
    public Employee(PersonalData personalData, ContactInfo contactInfo)
    {
        this.EmployeePersonalData = personalData;
        this.EmployeeContactInfo = contactInfo;
    }
    private void OfferService(Categories category, string description, int price)
    {
        // Offer service to customer
    }
    private void ContactEmployer(ContactInfo employerinfo)
    {
        // Contact employer
    }
}
