using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Output;

namespace Chainify.Synchronous.Linq
{
    public static class Output
    {
        public static IOutputGOutput<TOutput> Chain<TOutput>(this IOutput<TOutput> instance, IVoid other)
        {
            return new OutputBuilder<TOutput>();
        }
        
        public static IOutputGOutput<TOutput> Chain<TOutput>(this IOutput<TOutput> instance, IGenericVoid other)
        {
            return new OutputBuilder<TOutput>();
        }
        
        public static IOutputGOutput<TOutput> Chain<TOutput>(this IOutput<TOutput> instance, IInput<TOutput> other)
        {
            return new OutputBuilder<TOutput>();
        }
        
        public static IOutputGOutput<TOutput> Chain<TOutput>(this IOutput<TOutput> instance, IGenericInput other)
        {
            return new OutputBuilder<TOutput>();
        }
        
        public static IInputGInputIoGIo<TOutput> Chain<TOutput, TOtherOutput>(this IOutput<TOutput> instance, IInputOutput<TOutput, TOtherOutput> other)
        {
            return new OutputBuilder<TOutput>();
        }
        
        public static IInputGInputIoGIo<TOutput> Chain<TOutput>(this IOutput<TOutput> instance, IGenericInputOutput other)
        {
            return new OutputBuilder<TOutput>();
        }
    }
}
