using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Input.GVoidVoid.IChain;

namespace Chainify.Synchronous.Generic.Input.GInputInputGIoIo
{
    public interface IChain : IGVoidVoid
    {
        GOutputOutput.IChain Chain<TOtherInput>(IInput<TOtherInput> other);

        IChain Chain(IGenericInputOutput other);

        IChain Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
