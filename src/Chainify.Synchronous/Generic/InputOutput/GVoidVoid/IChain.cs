using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.InputOutput.GOutputOutput.IChain;

namespace Chainify.Synchronous.Generic.InputOutput.GVoidVoid
{
    public interface IChain : IGenericInputOutput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
