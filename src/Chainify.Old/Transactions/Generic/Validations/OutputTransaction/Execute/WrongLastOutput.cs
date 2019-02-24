using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Old.Contract;
using Chainify.Old.Contract.Generic;
using Chainify.Old.Exceptions;

namespace Chainify.Old.Transactions.Generic.Validations.OutputTransaction.Execute
{
    public class WrongLastOutput<TRequiredOutput> : IValidation
    {
        private readonly IEnumerable<ITransactionEntity> _entities;

        public WrongLastOutput(IEnumerable<ITransactionEntity> entities)
        {
            _entities = entities;
        }

        public void Validate()
        {
            ITransactionEntity last = _entities.Last();

            if (!(last is IOutputExecute<TRequiredOutput>) && !HasRightOutput(last))
            {
                throw new WrongSuccessionException();
            }
        }

        private bool HasRightOutput(ITransactionEntity entity)
        {
            if (entity is IIOExecute)
            {
                IEnumerable<Type> arguments = entity.GetType().GetGenericArguments();

                if (arguments.Last() == typeof(TRequiredOutput))
                {
                    return true;
                }
            }

            return false;
        }
    }
}