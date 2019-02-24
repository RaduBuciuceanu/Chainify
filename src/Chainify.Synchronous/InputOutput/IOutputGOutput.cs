using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.InputOutput
{
    public interface IOutputGOutput<in TInput, out TOutput> : IVoidGVoid<TInput, TOutput>
    {
        IInputGInputIoGIo<TInput, TOutput> Chain<TOtherOutput>(IOutput<TOtherOutput> other);

        IInputGInputIoGIo<TInput, TOutput> Chain(IGenericOutput other);
    }
}
