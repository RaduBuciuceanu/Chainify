using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Void.GOutputOutput.IChain;

namespace Chainify.Synchronous.Generic.Void.GVoidVoid
{
    public interface IChain : IGenericVoid
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
