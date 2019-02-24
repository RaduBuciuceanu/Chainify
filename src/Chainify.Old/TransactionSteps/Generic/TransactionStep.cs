using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.TransactionSteps.Generic
{
    public abstract class TransactionStep<TInput, TOutput> : ITransactionStep<TInput, TOutput>
    {
        public virtual void BeforeExecution()
        {
        }

        public object Execute(object input)
        {
            return Execute((TInput) input);
        }

        public virtual void AfterExecution()
        {
        }

        public virtual void Rollback()
        {
        }

        public abstract TOutput Execute(TInput input);
    }
}