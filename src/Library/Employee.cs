﻿namespace Library;
public class Employee
{
    private PersonalData EmployeePersonalData { get; set; }
    private ContactInfo EmployeeContactInfo { get; set; }
    public int Reputation { get; set; }

    public Employee(PersonalData personalData, ContactInfo contactInfo)
    {
        EmployeePersonalData = personalData;
        EmployeeContactInfo = contactInfo;
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
