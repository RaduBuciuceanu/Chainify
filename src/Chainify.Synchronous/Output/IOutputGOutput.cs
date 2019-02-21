using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Output
{
    public interface IOutputGOutput<out TOutput> : IVoidGVoid<TOutput>
    {
        IInputGInputIoGIo<TOutput> Chain<TOtherOutput>(IOutput<TOtherOutput> other);
        
        IInputGInputIoGIo<TOutput> Chain(IGenericOutput other);
    }
}
