using System.Collections.Generic;
using System.Linq;
using Chainify.Old.Contract;
using Chainify.Old.Exceptions;

namespace Chainify.Old.Transactions.Generic.Validations
{
    public class EmptyQueue : IValidation
    {
        private readonly IEnumerable<ITransactionEntity> _entities;

        public EmptyQueue(IEnumerable<ITransactionEntity> entities)
        {
            _entities = entities;
        }

        public void Validate()
        {
            if (!_entities.Any())
            {
                throw new WrongSuccessionException("The transaction you try to execute contains no steps.");
            }
        }
    }
}