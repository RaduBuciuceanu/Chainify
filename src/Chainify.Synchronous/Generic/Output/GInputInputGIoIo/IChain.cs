using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Output.GOutputOutput.IChain;
using IGVoidVoid = Chainify.Synchronous.Generic.Output.GVoidVoid.IChain;

namespace Chainify.Synchronous.Generic.Output.GInputInputGIoIo
{
    public interface IChain : IGVoidVoid
    {
        IGOutputOutput Chain(IGenericInput other);

        IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other);

        IChain Chain(IGenericInputOutput other);

        IChain Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other);
    }
}
