namespace contact_manager.Models.Data.Customer;

public class Customer : Person
{
    public string CustomerNumber => this.Id.ToString().PadLeft(5, '0');
    public string? CompanyName { get; init; }
    public CustomerType CustomerType { get; init; }
    /*
     TODO Was ist das?
    - CompanyAddress
    - Firmenkontakt (Person, Email-Adresse)
     */
}