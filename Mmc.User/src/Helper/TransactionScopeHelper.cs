using System.Transactions;

namespace Mmc.User.Helper;

public class TransactionScopeHelper
{
    public static TransactionScope GetInstance => new(TransactionScopeAsyncFlowOption.Enabled);
}