using Chainify.Old.Contract.Generic;

namespace Chainify.Old.Contract.TransactionSteps.Generic
{
    public interface IOutputTransactionStep<out TOutput> :
        ITransactionEntity, IBeforeExecution, IOutputExecute<TOutput>, IAfterExecution, IRollback
    {
    }
}