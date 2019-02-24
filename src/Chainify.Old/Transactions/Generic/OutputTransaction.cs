using Chainify.Old.Contract.Generic;
using Chainify.Old.Contract.Transactions.Generic;
using Chainify.Old.Contract.TransactionSteps;
using Chainify.Old.Contract.TransactionSteps.Generic;
using Chainify.Old.Transactions.Generic.Grammar.OutputTransaction;
using Chainify.Old.Transactions.Generic.Validations;
using Chainify.Old.Transactions.Generic.Validations.OutputTransaction.Execute;

namespace Chainify.Old.Transactions.Generic
{
    public class OutputTransaction<TOutput> : TransactionBase, IOutputTransaction<TOutput>
    {
        private protected override IEngine Engine { get; }

        public OutputTransaction()
        {
            Engine = new Engine(Entities);
        }

        public OutputVoidContinue<TOutput> ContinueWith(ITransactionStep step)
        {
            Entities.Add(step);
            return new OutputVoidContinue<TOutput>(this);
        }

        public IOInputContinueExecute<TOutput, TOutput> ContinueWith(IOutputTransactionStep<TOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinueExecute<TOutput, TOutput>(this);
        }

        public IOInputContinue<TOutput, TStepOutput> ContinueWith<TStepOutput>(IOutputTransactionStep<TStepOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinue<TOutput, TStepOutput>(this);
        }

        TOutput IOutputExecute<TOutput>.Execute()
        {
            RunExecuteValidations();
            BaseExecute();
            return (TOutput) Engine.Current;
        }

        public object Execute()
        {
            return ((IOutputExecute<TOutput>) this).Execute();
        }

        private void RunExecuteValidations()
        {
            var validations = new IValidation[]
            {
                new EmptyQueue(Entities),
                new WrongLastOutput<TOutput>(Entities),
            };

            foreach (IValidation validation in validations)
            {
                validation.Validate();
            }
        }
    }
}