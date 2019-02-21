using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.Contract.Transactions.Generic
{
    public interface IInputTransaction<in TInput> : IInputTransactionStep<TInput>
    {
    }
}