using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Input
{
    public interface IOutputGOutput<in TInput> : IVoidGVoid<TInput>
    {
        IInputGInputIoGIo<TInput> Chain<TOtherOutput>(IOutput<TOtherOutput> other);

        IInputGInputIoGIo<TInput> Chain(IGenericOutput other);
    }
}
