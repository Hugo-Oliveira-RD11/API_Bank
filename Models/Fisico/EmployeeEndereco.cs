using Banquinho.Models.Employee;

namespace Banquinho.Models.Fisico;

public class EmployeeEndereco
{
    public Guid id { get; set; }

    public Employees employee { get; set; }
    public ulong CPF_id { get; set; }
    
    public Guid Endereco_Id { get; set; }
    public Endereco endereco { get; set; }
}