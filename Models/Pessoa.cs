using System.ComponentModel.DataAnnotations;

namespace Models;

public class People
{
    [Key]
    public int id {get;set;}
    public string name {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? nascimento {get;set;}
    public Endereco? endereco {get;set;}
    public ContaCP? poupanca {get;set;}
    public ContaCC? corrente {get;set;}
}
