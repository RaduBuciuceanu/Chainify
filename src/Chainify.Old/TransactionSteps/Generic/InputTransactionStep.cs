using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.TransactionSteps.Generic
{
    public abstract class InputTransactionStep<TInput> : IInputTransactionStep<TInput>
    {
        public virtual void BeforeExecution()
        {
        }

        public void Execute(object input)
        {
            Execute((TInput) input);
        }

        public virtual void AfterExecution()
        {
        }

        public virtual void Rollback()
        {
        }

        public abstract void Execute(TInput input);
    }
}