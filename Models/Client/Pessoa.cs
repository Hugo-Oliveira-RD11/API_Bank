using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Client.Account;
using Banquinho.Models.Contact;
using Banquinho.Models.Fisico;

namespace Banquinho.Models.Client;

public class People
{
    [Key]
    public ulong CPF {get;set;}
    public string? First_name {get;set;}
    public string? Last_name {get;set;}
    [DataType(DataType.Date)]
    public DateOnly? nascimento {get;set;}
    public string? Celular { get; set; }

    public AccountCorrent accountCorrent { get; set; }
    public Guid accountCorrent_Id { get; set; }
    public AccountPoupanca accountPoupanca { get; set; }
    public Guid accountPoupanca_Id { get; set; }
    public PeopleContacts PeopleContacts { get; set; }
    public Guid contacts_Id { get; set; }
    
    public ICollection<PeopleEndereco> peopleEndereco { get; set; }
    
    
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Modified {get;set;}
}
