using Chainify.Old.Contract.Transactions.Generic;
using Chainify.Old.Contract.TransactionSteps.Generic;
using Chainify.Old.Transactions.Generic.Grammar.Transaction;
using Chainify.Old.Transactions.Generic.Validations;
using Chainify.Old.Transactions.Generic.Validations.Transaction.Execute;

namespace Chainify.Old.Transactions.Generic
{
    public class Transaction<TInput, TOutput> : TransactionBase, ITransaction<TInput, TOutput>
    {
        private protected override IEngine Engine { get; }

        public Transaction()
        {
            Engine = new Engine(Entities);
        }

        public OutputVoidContinue<TInput, TOutput> ContinueWith(IInputTransactionStep<TInput> step)
        {
            Entities.Add(step);
            return new OutputVoidContinue<TInput, TOutput>(this);
        }

        public IOInputContinue<TInput, TOutput, TOutput> ContinueWith(ITransactionStep<TInput, TOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinueExecute<TInput, TOutput, TOutput>(this);
        }

        public IOInputContinue<TInput, TOutput, TStepOutput>
            ContinueWith<TStepOutput>(ITransactionStep<TInput, TStepOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinue<TInput, TOutput, TStepOutput>(this);
        }

        public TOutput Execute(TInput input)
        {
            RunExecuteValidations();
            Engine.Current = input;
            BaseExecute();
            return (TOutput) Engine.Current;
        }

        private void RunExecuteValidations()
        {
            var validations = new IValidation[]
            {
                new EmptyQueue(Entities),
                new WithoutLastOutput(Entities),
                new WrongLastOutput<TOutput>(Entities),
            };

            foreach (IValidation validation in validations)
            {
                validation.Validate();
            }
        }

        public object Execute(object input)
        {
            return Execute((TInput) input);
        }
    }
}