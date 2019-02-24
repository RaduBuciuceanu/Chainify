using Chainify.Old.Contract;
using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.TransactionSteps.Generic
{
    public abstract class OutputTransactionStep<TOutput> : IOutputTransactionStep<TOutput>
    {
        public virtual void BeforeExecution()
        {
        }

        object IOutputExecute.Execute()
        {
            return Execute();
        }

        public virtual void AfterExecution()
        {
        }

        public virtual void Rollback()
        {
        }

        public abstract TOutput Execute();
    }
}