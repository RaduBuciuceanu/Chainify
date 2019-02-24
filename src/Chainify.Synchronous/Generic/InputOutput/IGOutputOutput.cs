using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.InputOutput
{
    public interface IGOutputOutput : IGVoidVoid
    {
        IGInputInputGIoIo Chain(IGenericOutput other);

        IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other);
    }
}
