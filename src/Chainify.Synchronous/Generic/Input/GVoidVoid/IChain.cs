using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Input.GOutputOutput.IChain;

namespace Chainify.Synchronous.Generic.Input.GVoidVoid
{
    public interface IChain : IGenericInput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
