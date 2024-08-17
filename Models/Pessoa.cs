using System.ComponentModel.DataAnnotations;
using Models.Fisico;

namespace Models;

public class People
{
    [Key]
    public uint id {get;set;}
    public uint CPF {get;set;}
    public string? name {get;set;}
    public DateTime? nascimento {get;set;}
    public Endereco? endereco {get;set;}
    public Agencia? agencia  {get;set;}
}
