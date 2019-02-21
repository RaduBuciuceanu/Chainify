using Chainify.Old.Contract.Generic;

namespace Chainify.Old.Contract.TransactionSteps.Generic
{
    public interface ITransactionStep<in TInput, out TOutput> :
        ITransactionEntity, IBeforeExecution, IExecute<TInput, TOutput>, IAfterExecution, IRollback
    {
    }
}
