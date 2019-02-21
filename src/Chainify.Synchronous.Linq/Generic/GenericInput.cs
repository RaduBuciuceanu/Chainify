using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Generic.Input;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericInput
    {
        public static IGOutputOutput Chain(this IGenericInput instance, IGenericVoid other)
        {
            return new GenericInputBuilder();
        }

        public static IGOutputOutput Chain(this IGenericInput instance, IVoid other)
        {
            return new GenericInputBuilder();
        }

        public static IGInputInputGIoIo Chain(this IGenericInput instance, IGenericOutput other)
        {
            return new GenericInputBuilder();
        }

        public static IGInputInputGIoIo Chain<TOtherOutput>(this IGenericInput instance, IOutput<TOtherOutput> other)
        {
            return new GenericInputBuilder();
        }
    }
}
