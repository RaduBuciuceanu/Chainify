using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.InputOutput;

namespace Chainify.Synchronous
{
    public class InputOutputBuilder<TInput, TOutput> : Proxy, IOutputGOutput<TInput, TOutput>, IInputGInputIoGIo<TInput, TOutput>
    {
        public Type OneOutput { get; set; }

        public TOutput Execute(TInput input)
        {
            object oneResult = Engine.WithInput(input).WithInstance(One).Execute();
            object otherResult = Engine.WithInput(oneResult).WithInstance(Other).Execute();
            return (TOutput)otherResult;
        }
        
        public IOutputGOutput<TInput, TOutput> Chain(IVoid other)
        {
            return this;
        }
        
        public IOutputGOutput<TInput, TOutput> Chain(IGenericVoid other)
        {
            return this;
        }

        public IOutputGOutput<TInput, TOutput> Chain<TOtherOutput>(IInput<TOtherOutput> other)
        {
            return this;
        }

        public IOutputGOutput<TInput, TOutput> Chain(IGenericInput other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput, TOutput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput, TOutput> Chain(IGenericInputOutput other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput, TOutput> Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput, TOutput> Chain(IGenericOutput other)
        {
            return this;
        }
    }
}
