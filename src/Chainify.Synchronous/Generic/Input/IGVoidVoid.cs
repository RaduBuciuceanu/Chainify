using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Input
{
    public interface IGVoidVoid : IGenericInput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
