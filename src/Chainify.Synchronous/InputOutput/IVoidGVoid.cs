using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.InputOutput
{
    public interface IVoidGVoid<in TInput, out TOutput> : IInputOutput<TInput, TOutput>
    {
        IOutputGOutput<TInput, TOutput> Chain(IVoid other);

        IOutputGOutput<TInput, TOutput> Chain(IGenericVoid other);
    }
}
