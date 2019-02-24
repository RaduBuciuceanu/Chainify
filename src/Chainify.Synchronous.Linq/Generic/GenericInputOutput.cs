using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Generic.InputOutput;
using Chainify.Synchronous.Generic.InputOutput.GInputInputGIoIo;
using Chainify.Synchronous.Generic.InputOutput.GOutputOutput;
using IChain = Chainify.Synchronous.Generic.InputOutput.GOutputOutput.IChain;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericInputOutput
    {
        public static IChain Chain(this IGenericInputOutput instance, IGenericVoid other)
        {
            return new GenericInputOutputBuilder();
        }

        public static IChain Chain(this IGenericInputOutput instance, IVoid other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IChain Chain(this IGenericInputOutput instance, IGenericInput other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static IChain Chain<TOtherInput>(this IGenericInputOutput instance, IInput<TOtherInput> other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static Synchronous.Generic.InputOutput.GInputInputGIoIo.IChain Chain(this IGenericInputOutput instance, IGenericInputOutput other)
        {
            return new GenericInputOutputBuilder();
        }
        
        public static Synchronous.Generic.InputOutput.GInputInputGIoIo.IChain Chain<TOtherInput, TOtherOutput>(this IGenericInputOutput instance, IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return new GenericInputOutputBuilder();
        }
    }
}
