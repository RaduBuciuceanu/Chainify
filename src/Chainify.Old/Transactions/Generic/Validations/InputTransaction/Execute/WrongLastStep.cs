using System.Collections.Generic;
using System.Linq;
using Chainify.Old.Contract;
using Chainify.Old.Exceptions;

namespace Chainify.Old.Transactions.Generic.Validations.InputTransaction.Execute
{
    public class WrongLastStep : IValidation
    {
        private readonly IEnumerable<ITransactionEntity> _entities;

        public WrongLastStep(IEnumerable<ITransactionEntity> entities)
        {
            _entities = entities;
        }

        public void Validate()
        {
            ITransactionEntity last = _entities.Last();

            if (last is IOutputExecute || last is IIOExecute)
            {
                var message = "The transaction you try to execute contains a wrong last step. " +
                              "Input transactions can end only with a non output step.";

                throw new WrongSuccessionException(message);
            }
        }
    }
}