using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Output;

namespace Chainify.Synchronous
{
    public class OutputBuilder<TOutput> : Proxy, IInputGInputIoGIo<TOutput>, IOutputGOutput<TOutput>
    {
        public Type OneInput { get; set; }

        public Type OneOutput { get; set; }

        public IOutputGOutput<TOutput> Chain<TOtherInput>(IInput<TOtherInput> other)
        {
            return this;
        }

        public IOutputGOutput<TOutput> Chain(IGenericInput other)
        {
            return this;
        }

        public IInputGInputIoGIo<TOutput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TOutput> Chain(IGenericInputOutput other)
        {
            return this;
        }

        public IOutputGOutput<TOutput> Chain(IVoid other)
        {
            return this;
        }

        public IOutputGOutput<TOutput> Chain(IGenericVoid other)
        {
            return this;
        }

        public IInputGInputIoGIo<TOutput> Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TOutput> Chain(IGenericOutput other)
        {
            return this;
        }
        
        public TOutput Execute()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            object otherResult = Engine.WithInput(oneResult).WithInstance(Other).Execute();
            return (TOutput)otherResult;
        }
    }
}
