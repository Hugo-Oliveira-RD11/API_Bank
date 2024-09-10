using Banquinho.Models.Client.Account;

namespace Banquinho.Infra.Repository.Client.Account;

public interface IAccountCorrentRepository
{
    public bool Add(AccountCorrents accountCorrents);
    public bool Delete(AccountCorrents accountCorrents);
    public bool Update(AccountCorrents accountCorrents);
    public List<AccountCorrents> ListAll();
    public AccountCorrents Seach(Guid CPF);
}