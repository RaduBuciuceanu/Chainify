using Chainify.Old.Contract.Transactions;
using Chainify.Old.Contract.TransactionSteps;
using Chainify.Old.Contract.TransactionSteps.Generic;
using Chainify.Old.Transactions.Generic;
using Chainify.Old.Transactions.Generic.Validations;
using Chainify.Old.Transactions.Grammar.Transaction;
using Chainify.Old.Transactions.Validations.Transaction.Execute;

namespace Chainify.Old.Transactions
{
    public class Transaction : TransactionBase, ITransaction
    {
        private protected override IEngine Engine { get; }

        public Transaction()
        {
            Engine = new Engine(Entities);
        }

        public static Transaction Create()
        {
            return new Transaction();
        }

        public static Transaction<TInput, TOutput> Create<TInput, TOutput>()
        {
            return new Transaction<TInput, TOutput>();
        }

        public OutputVoidContinueExecute ContinueWith(ITransactionStep step)
        {
            Entities.Add(step);
            return new OutputVoidContinueExecute(this);
        }

        public IOInputContinue<TStepOutput> ContinueWith<TStepOutput>(IOutputTransactionStep<TStepOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinue<TStepOutput>(this);
        }

        public void Execute()
        {
            RunExecuteValidations();
            BaseExecute();
        }

        private void RunExecuteValidations()
        {
            var validations = new IValidation[]
            {
                new EmptyQueue(Entities),
                new LastOutput(Entities),
                new LastInputOutput(Entities),
            };

            foreach (IValidation validation in validations)
            {
                validation.Validate();
            }
        }
    }
}