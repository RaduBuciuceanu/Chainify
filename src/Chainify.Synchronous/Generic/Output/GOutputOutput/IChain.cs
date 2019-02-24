using Chainify.Core;
using Chainify.Core.Generic;
using IGVoidVoid = Chainify.Synchronous.Generic.Output.GVoidVoid.IChain;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.Output.GInputInputGIoIo.IChain;

namespace Chainify.Synchronous.Generic.Output.GOutputOutput
{
    public interface IChain : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
