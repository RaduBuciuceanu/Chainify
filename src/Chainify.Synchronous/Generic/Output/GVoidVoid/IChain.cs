using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Output.GOutputOutput.IChain;

namespace Chainify.Synchronous.Generic.Output.GVoidVoid
{
    public interface IChain : IGenericOutput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
