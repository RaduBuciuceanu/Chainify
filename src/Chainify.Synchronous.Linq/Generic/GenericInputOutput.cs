using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Generic.InputOutput;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericInputOutput
    {
        public static IGOutputOutput Chain(this IGenericInputOutput instance, IGenericVoid other)
        {
            return new GenericInputOutputBuilder();
        }

        public static IGOutputOutput Chain(this IGenericInputOutput instance, IVoid other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IGOutputOutput Chain(this IGenericInputOutput instance, IGenericInput other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IGOutputOutput Chain<TOtherInput>(this IGenericInputOutput instance, IInput<TOtherInput> other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IGInputInputGIoIo Chain(this IGenericInputOutput instance, IGenericInputOutput other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(this IGenericInputOutput instance, IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return new GenericInputOutputBuilder();
        }
    }
}
