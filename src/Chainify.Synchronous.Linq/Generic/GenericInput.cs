using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using IChain = Chainify.Synchronous.Generic.Input.GOutputOutput.IChain;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericInput
    {
        public static IChain Chain(this IGenericInput instance, IGenericVoid other)
        {
            return new GenericInputBuilder();
        }

        public static IChain Chain(this IGenericInput instance, IVoid other)
        {
            return new GenericInputBuilder();
        }

        public static Synchronous.Generic.Input.GInputInputGIoIo.IChain Chain(this IGenericInput instance, IGenericOutput other)
        {
            return new GenericInputBuilder();
        }

        public static Synchronous.Generic.Input.GInputInputGIoIo.IChain Chain<TOtherOutput>(this IGenericInput instance, IOutput<TOtherOutput> other)
        {
            return new GenericInputBuilder();
        }
    }
}
