using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Input
{
    public interface IInputGInputIoGIo<in TInput> : IVoidGVoid<TInput>
    {
        IOutputGOutput<TInput> Chain<TOtherInput>(IInput<TOtherInput> other);
        
        IOutputGOutput<TInput> Chain(IGenericInput other);
        
        IInputGInputIoGIo<TInput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
        
        IInputGInputIoGIo<TInput> Chain(IGenericInputOutput other);
    }
}
