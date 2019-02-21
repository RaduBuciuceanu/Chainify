using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Void
{
    public interface IGOutputOutput : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
