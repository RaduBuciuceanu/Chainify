using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Void
{
    public interface IGVoidVoid : IGenericVoid
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
