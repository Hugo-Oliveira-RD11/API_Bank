using System.ComponentModel.DataAnnotations;

namespace Banquinho.Models;

public class Endereco
{
    [Key]
    public Guid id {get;set;}
    public string? Bairro {get;set;}
    public uint NumCasa {get;set;}
    public uint CEP {get;set;}
    public string? Cidade {get;set;}
    public string? Rua {get;set;}
    public string? Estato {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}
}
