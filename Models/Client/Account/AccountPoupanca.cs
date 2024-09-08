using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Client.Account.History;

namespace Banquinho.Models.Client.Account;

public class AccountPoupanca
{
    [Key]
    public Guid Id_conta { get; set; }
    public uint NumConta { get; set; }
    public uint NumAgencia { get; set; }
    public ulong ChequeEspecial { get; set; }
    public ulong Caixa { get; set; }
    public DateOnly Data_Cobranca { get; set; }

    public People people { get; set; }
    public ulong CPF_id { get; set; }

    public ICollection<HistoryPoupanca> history { get; set; }
}