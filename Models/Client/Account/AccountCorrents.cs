using System.ComponentModel.DataAnnotations;
using Banquinho.Models.Client.Account.History;
namespace Banquinho.Models.Client.Account;

public class AccountCorrents
{
    [Key]
    public Guid Id_conta { get; set; }
    public uint NumConta { get; set; }
    public uint NumAgencia { get; set; }
    public ulong LimiteAtual { get; set; }
    public DateOnly Data_Cobranca { get; set; }

    public Peoples people { get; set; }
    public ulong CPF_id { get; set; }

    public ICollection<HistoryCorrents> history_mouth { get; set; } = new List<HistoryCorrents>();

}
