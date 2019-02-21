using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.InputOutput;

namespace Chainify.Synchronous.Linq
{
    public static class InputOutput
    {
        public static IOutputGOutput<TInput, TOutput> Chain<TInput, TOutput>(this IInputOutput<TInput, TOutput> instance, IVoid other)
        {
            return new InputOutputBuilder<TInput, TOutput>();
        }
        
        public static IOutputGOutput<TInput, TOutput> Chain<TInput, TOutput>(this IInputOutput<TInput, TOutput> instance, IGenericVoid other)
        {
            return new InputOutputBuilder<TInput, TOutput>();
        }

        public static IOutputGOutput<TInput, TOutput> Chain<TInput, TOutput, TOtherOutput>(this IInputOutput<TInput, TOutput> instance, IInput<TOtherOutput> other)
        {
            return new InputOutputBuilder<TInput, TOutput>();
        }

        public static IOutputGOutput<TInput, TOutput> Chain<TInput, TOutput>(this IInputOutput<TInput, TOutput> instance, IGenericInput other)
        {
            return new InputOutputBuilder<TInput, TOutput>();
        }
    }
}
