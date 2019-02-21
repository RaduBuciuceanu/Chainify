using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.Contract.Transactions.Generic
{
    public interface IOutputTransaction<out TOutput> : IOutputTransactionStep<TOutput>
    {
    }
}