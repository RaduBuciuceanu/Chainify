using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Void
{
    public interface IGInputInputGIoIo : IGVoidVoid
    {
        IGOutputOutput Chain(IGenericInput other);

        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IGInputInputGIoIo Chain(IGenericInputOutput other);

        IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
