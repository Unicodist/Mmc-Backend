using System.Transactions;

namespace Mmc.Notice.Helper;

public class TransactionScopeHelper
{
    public static TransactionScope GetInstance => new(TransactionScopeAsyncFlowOption.Enabled);
}