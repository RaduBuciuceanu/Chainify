using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Input
{
    public interface IGInputInputGIoIo : IGVoidVoid
    {
        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IGInputInputGIoIo Chain(IGenericInputOutput other);

        IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
