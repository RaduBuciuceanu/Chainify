using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Output.GOutputOutput.IChain;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.Output.GInputInputGIoIo.IChain;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericOutput
    {
        public static IGOutputOutput Chain(this IGenericOutput instance, IGenericVoid other)
        {
            return new GenericOutputBuilder();
        }

        public static IGOutputOutput Chain(this IGenericOutput instance, IVoid other)
        {
            return new GenericOutputBuilder();
        }
        
        public static IGOutputOutput Chain(this IGenericOutput instance, IGenericInput other)
        {
            return new GenericOutputBuilder();
        }
        
        public static IGOutputOutput Chain<TOtherInput>(this IGenericOutput instance, IInput<TOtherInput> other)
        {
            return new GenericOutputBuilder();
        }
        
        public static IGInputInputGIoIo Chain(this IGenericOutput instance, IGenericInputOutput other)
        {
            return new GenericOutputBuilder();
        }
        
        public static IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(this IGenericOutput instance, IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return new GenericOutputBuilder();
        }
    }
}
