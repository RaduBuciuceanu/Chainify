using Chainify.Old.Contract.Generic;

namespace Chainify.Old.Contract.TransactionSteps.Generic
{
    public interface IInputTransactionStep<in TInput> :
        ITransactionEntity, IBeforeExecution, IInputExecute<TInput>, IAfterExecution, IRollback
    {
    }
}