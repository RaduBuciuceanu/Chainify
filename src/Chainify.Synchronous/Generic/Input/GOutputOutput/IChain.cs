using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Input.GVoidVoid.IChain;

namespace Chainify.Synchronous.Generic.Input.GOutputOutput
{
    public interface IChain : IGVoidVoid
    {
        GInputInputGIoIo.IChain Chain(IGenericOutput other);

        GInputInputGIoIo.IChain Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
