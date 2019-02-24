using System.Collections.Generic;
using Chainify.Core;

namespace Chainify.Synchronous
{
    public class Chain
    {
        private readonly OperationExecutor _executor;
        private readonly IEnumerable<IChainable> _operations;
        
        public Chain(IEnumerable<IChainable> operations)
        {
            _executor = new OperationExecutor();
            _operations = operations;
        }

        public object Execute(object input = default(object))
        {
            foreach (IChainable operation in _operations)
            {
                input = _executor.WithInput(input).WithInstance(operation).Execute();
            }

            return input;
        }
    }
}
