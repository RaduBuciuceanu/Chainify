using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.InputOutput.GOutputOutput.IChain;
using IGVoidVoid = Chainify.Synchronous.Generic.InputOutput.GVoidVoid.IChain;

namespace Chainify.Synchronous.Generic.InputOutput.GInputInputGIoIo
{
    public interface IChain : IGVoidVoid
    {
        IGOutputOutput Chain(IGenericInput other);

        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IChain Chain(IGenericInputOutput other);

        IChain Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
