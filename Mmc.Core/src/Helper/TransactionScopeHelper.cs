using System.Transactions;

namespace Mmc.Core.Helper;

public class TransactionScopeHelper
{
    public static TransactionScope GetInstance => new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
}