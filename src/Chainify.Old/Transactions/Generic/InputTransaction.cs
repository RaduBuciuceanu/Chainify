using Chainify.Old.Contract.Transactions.Generic;
using Chainify.Old.Contract.TransactionSteps.Generic;
using Chainify.Old.Transactions.Generic.Grammar.InputTransaction;
using Chainify.Old.Transactions.Generic.Validations;
using Chainify.Old.Transactions.Generic.Validations.InputTransaction.Execute;

namespace Chainify.Old.Transactions.Generic
{
    public class InputTransaction<TInput> : TransactionBase, IInputTransaction<TInput>
    {
        private protected override IEngine Engine { get; }

        public InputTransaction()
        {
            Engine = new Engine(Entities);
        }

        public OutputVoidContinueExecute<TInput> ContinueWith(IInputTransactionStep<TInput> step)
        {
            Entities.Add(step);
            return new OutputVoidContinueExecute<TInput>(this);
        }

        public IOInputContinue<TInput, TStepOutput> ContinueWith<TStepOutput>(
            ITransactionStep<TInput, TStepOutput> step)
        {
            Entities.Add(step);
            return new IOInputContinue<TInput, TStepOutput>(this);
        }

        public void Execute(TInput input)
        {
            RunExecuteValidations();
            Engine.Current = input;
            BaseExecute();
        }

        public void Execute(object input)
        {
            Execute((TInput) input);
        }

        private void RunExecuteValidations()
        {
            var validations = new IValidation[]
            {
                new EmptyQueue(Entities),
                new WrongLastStep(Entities), 
            };

            foreach (IValidation validation in validations)
            {
                validation.Validate();
            }
        }
    }
}