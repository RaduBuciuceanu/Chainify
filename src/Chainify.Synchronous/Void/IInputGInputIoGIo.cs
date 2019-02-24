using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Void
{
    public interface IInputGInputIoGIo : IVoidGVoid
    {
        IOutputGOutput Chain<TOtherInput>(IInput<TOtherInput> other);
        
        IOutputGOutput Chain(IGenericInput other);

        IInputGInputIoGIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
        
        IInputGInputIoGIo Chain(IGenericInputOutput other);
    }
}
