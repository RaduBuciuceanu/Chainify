using Chainify.Old.Contract.TransactionSteps;
using Chainify.Old.Contract.TransactionSteps.Generic;

namespace Chainify.Old.Transactions.Grammar.Transaction
{
    public class OutputVoidContinueExecute : ContinueBase
    {
        public OutputVoidContinueExecute(Transactions.Transaction transaction) : base(transaction)
        {
        }
        
        public IOInputContinue<TStepOutput> ContinueWith<TStepOutput>(IOutputTransactionStep<TStepOutput> step)
        {
            Transaction.Entities.Add(step);
            return new IOInputContinue<TStepOutput>(Transaction);
        }

        public OutputVoidContinueExecute ContinueWith(ITransactionStep step)
        {
            Transaction.Entities.Add(step);
            return new OutputVoidContinueExecute(Transaction);
        }

        public void Execute()
        {
            Transaction.Execute();
        }
    }
}