using Chainify.Old.Contract.TransactionSteps;

namespace Chainify.Old.TransactionSteps
{
    public abstract class TransactionStep : ITransactionStep
    {
        public virtual void BeforeExecution()
        {
        }

        public virtual void AfterExecution()
        {
        }

        public virtual void Rollback()
        {
        }

        public abstract void Execute();
    }
}