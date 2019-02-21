using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Input
{
    public interface IVoidGVoid<in TInput> : IInput<TInput>
    {
        IOutputGOutput<TInput> Chain(IVoid other);
        
        IOutputGOutput<TInput> Chain(IGenericVoid other);
    }
}
