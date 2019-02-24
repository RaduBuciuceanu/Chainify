using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Input.GVoidVoid
{
    public interface IChain : IGenericInput
    {
        GOutputOutput.IChain Chain(IGenericVoid other);

        GOutputOutput.IChain Chain(IVoid other);
    }
}
