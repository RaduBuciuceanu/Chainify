using System.Collections.Generic;
using System.Linq;
using Chainify.Old.Contract;
using Chainify.Old.Exceptions;

namespace Chainify.Old.Transactions.Generic.Validations.Transaction.Execute
{
    public class WithoutLastOutput : IValidation
    {
        private readonly IEnumerable<ITransactionEntity> _entities;

        public WithoutLastOutput(IEnumerable<ITransactionEntity> entities)
        {
            _entities = entities;
        }
        
        public void Validate()
        {
            ITransactionEntity last = _entities.Last();

            if (last is IExecute || last is IInputExecute)
            {
                throw new WrongSuccessionException();
            }
        }
    }
}