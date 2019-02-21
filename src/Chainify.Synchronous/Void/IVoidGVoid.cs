using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Void
{
    public interface IVoidGVoid : IVoid
    {
        IOutputGOutput Chain(IVoid other);

        IOutputGOutput Chain(IGenericVoid other);
    }
}
