using System.Transactions;

namespace Mmc.Blog.Helper;

public class TransactionScopeHelper
{
    public static TransactionScope GetInstance => new(TransactionScopeAsyncFlowOption.Enabled);
}