using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Input;

namespace Chainify.Synchronous.Linq
{
    public static class Input
    {
        public static IOutputGOutput<TInput> Chain<TInput>(this IInput<TInput> instance, IVoid other)
        {
            return new InputBuilder<TInput> { OneInput = typeof(TInput) };
        }
        
        public static IOutputGOutput<TInput> Chain<TInput>(this IInput<TInput> instance, IGenericVoid other)
        {
            return new InputBuilder<TInput>();
        }
        
        public static IInputGInputIoGIo<TOtherOutput> Chain<TInput, TOtherOutput>(this IInput<TInput> instance, IOutput<TOtherOutput> other)
        {
            return new InputBuilder<TOtherOutput> { OneInput = typeof(TInput) };
        }

        public static IInputGInputIoGIo<TInput> Chain<TInput>(this IInput<TInput> instance, IGenericOutput other)
        {
            return new InputBuilder<TInput>();
        }
    }
}
