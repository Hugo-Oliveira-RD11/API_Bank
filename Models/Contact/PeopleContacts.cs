using Banquinho.Models.Client;

namespace Banquinho.Models.Contact;

public class PeopleContacts
{
    public Guid Id { get; set; }
    
    public Contacts contacts { get; set; }
    public Guid contacts_id { get; set; }
    
    public People people { get; set; }
    public ulong CPF_id { get; set; }
}