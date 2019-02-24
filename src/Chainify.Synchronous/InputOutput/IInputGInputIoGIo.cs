using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.InputOutput
{
    public interface IInputGInputIoGIo<in TInput, out TOutput> : IVoidGVoid<TInput, TOutput>
    {
        IOutputGOutput<TInput, TOutput> Chain<TOtherInput>(IInput<TOtherInput> other);
        
        IOutputGOutput<TInput, TOutput> Chain(IGenericInput other);

        IInputGInputIoGIo<TInput, TOutput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);

        IInputGInputIoGIo<TInput, TOutput> Chain(IGenericInputOutput other);
    }
}
