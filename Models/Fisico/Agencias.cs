using System.ComponentModel.DataAnnotations;

namespace Models.Fisico;

public class Agencia
{
    [Key]
    public int id {get;set;}
    public DateTime Created {get;set;}
    public Endereco? endereco {get;set;}
    public ICollection<People> peoples {get;set;} = new List<People>();
}
