using System.ComponentModel.DataAnnotations;
using Models.Fisico;

namespace Models;

public class People
{
    [Key]
    public int id {get;set;}
    public int CPF {get;set;}
    public string? name {get;set;}
    [DataType(DataType.DateTime)]
    public DateTime? nascimento {get;set;}
    public Endereco? endereco {get;set;}
    public Agencia? agencia {get;set;}
}
