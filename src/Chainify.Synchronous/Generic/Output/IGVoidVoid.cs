using Chainify.Core;
using Chainify.Core.Generic;

namespace Chainify.Synchronous.Generic.Output
{
    public interface IGVoidVoid : IGenericOutput
    {
        IGOutputOutput Chain(IGenericVoid other);

        IGOutputOutput Chain(IVoid other);
    }
}
