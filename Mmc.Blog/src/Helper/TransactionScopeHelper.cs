using System.Transactions;

namespace Mmc.Blog.Helper;

public static class TransactionScopeHelper
{
    private static readonly TransactionOptions TransactionOptions = new()
    {
        IsolationLevel = IsolationLevel.ReadCommitted,
        Timeout = TransactionManager.MaximumTimeout
    };
    public static TransactionScope GetInstance => new(TransactionScopeOption.Required,TransactionOptions,TransactionScopeAsyncFlowOption.Enabled);
}
