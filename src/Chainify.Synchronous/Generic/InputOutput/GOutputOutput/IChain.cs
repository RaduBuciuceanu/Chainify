using Chainify.Core;
using Chainify.Core.Generic;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.InputOutput.GInputInputGIoIo.IChain;
using IGVoidVoid = Chainify.Synchronous.Generic.InputOutput.GVoidVoid.IChain;

namespace Chainify.Synchronous.Generic.InputOutput.GOutputOutput
{
    public interface IChain : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
