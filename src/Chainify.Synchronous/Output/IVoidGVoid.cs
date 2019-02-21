using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Output
{
    public interface IVoidGVoid<out TOutput> : IOutput<TOutput>
    {
        IOutputGOutput<TOutput> Chain(IVoid other);

        IOutputGOutput<TOutput> Chain(IGenericVoid other);
    }
}
