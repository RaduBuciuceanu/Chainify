using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Void
{
    public interface IOutputGOutput : IVoidGVoid
    {
        IInputGInputIoGIo Chain<TOutput>(IOutput<TOutput> other);

        IInputGInputIoGIo Chain(IGenericOutput other);
    }
}
