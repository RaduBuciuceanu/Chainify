using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Void.GVoidVoid.IChain;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.Void.GInputInputGIoIo.IChain;

namespace Chainify.Synchronous.Generic.Void.GOutputOutput
{
    public interface IChain : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
