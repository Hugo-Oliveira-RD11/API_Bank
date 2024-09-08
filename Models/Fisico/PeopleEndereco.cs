using Banquinho.Models.Client;

namespace Banquinho.Models.Fisico;

public class PeopleEndereco
{
    public Guid id { get; set; }

    public People people { get; set; }
    public ulong CPF_id { get; set; }
    
    public Guid Endereco_Id { get; set; }
    public Endereco endereco { get; set; }
}
