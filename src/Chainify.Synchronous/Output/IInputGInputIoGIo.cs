using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Output
{
    public interface IInputGInputIoGIo<out TOutput> : IOutput<TOutput>
    {
        IOutputGOutput<TOutput> Chain<TOtherInput>(IInput<TOtherInput> other);

        IOutputGOutput<TOutput> Chain(IGenericInput other);

        IInputGInputIoGIo<TOutput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);

        IInputGInputIoGIo<TOutput> Chain(IGenericInputOutput other);
    }
}
