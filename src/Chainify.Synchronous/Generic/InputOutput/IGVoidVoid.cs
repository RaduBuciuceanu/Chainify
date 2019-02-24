using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.InputOutput
{
    public interface IGVoidVoid : IGenericInputOutput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
