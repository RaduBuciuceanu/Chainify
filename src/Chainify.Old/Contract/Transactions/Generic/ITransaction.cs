using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.Contract.Transactions.Generic
{
    public interface ITransaction<in TInput, out TOutput> : ITransactionStep<TInput, TOutput>
    {
    }
}