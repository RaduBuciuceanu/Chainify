using System.Collections.Generic;
using System.Linq;
using Chainify.Old.Contract;
using Chainify.Old.Exceptions;

namespace Chainify.Old.Transactions.Validations.Transaction.Execute
{
    public class LastInputOutput : IValidation
    {
        private readonly IEnumerable<ITransactionEntity> _entities;

        public LastInputOutput(IEnumerable<ITransactionEntity> entities)
        {
            _entities = entities;
        }
        
        public void Validate()
        {
            ITransactionEntity last = _entities.Last();

            if (last is IIOExecute)
            {
                throw new WrongSuccessionException();
            }
        }
    }
}