using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Output
{
    public interface IGInputInputGIoIo : IGVoidVoid
    {
        IGOutputOutput Chain(IGenericInput other);

        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IGInputInputGIoIo Chain(IGenericInputOutput other);

        IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
