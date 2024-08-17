using System.ComponentModel.DataAnnotations;

namespace Models;

public class Endereco
{
    [Key]
    public int id {get;set;}
    public string? Bairro {get;set;}
    public uint NumCasa {get;set;}
    public uint CEP {get;set;}
    public string? Cidade {get;set;}
    public string? Rua {get;set;}
    public string? Estato {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? Created {get;set;}
    public People? people {get;set;}
}
