using Chainify.Old.Contract.TransactionSteps;
using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.Transactions.Generic.Grammar.InputTransaction
{
    public class OutputVoidContinueExecute<TOriginalInput> : ContinueBase<TOriginalInput>
    {
        public OutputVoidContinueExecute(InputTransaction<TOriginalInput> transaction) : base(transaction)
        {
        }

        public OutputVoidContinueExecute<TOriginalInput> ContinueWith(ITransactionStep step)
        {
            Transaction.Entities.Add(step);
            return this;
        }

        public IOInputContinue<TOriginalInput, TOutput> ContinueWith<TOutput>(IOutputTransactionStep<TOutput> step)
        {
            Transaction.Entities.Add(step);
            return new IOInputContinue<TOriginalInput, TOutput>(Transaction);
        }

        public void Execute(TOriginalInput input)
        {
            Transaction.Execute(input);
        }
    }
}