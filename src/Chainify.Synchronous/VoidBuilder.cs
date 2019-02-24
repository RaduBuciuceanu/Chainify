using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Void;

namespace Chainify.Synchronous
{
    public class VoidBuilder : Proxy, IInputGInputIoGIo, IOutputGOutput
    {
        public Type OneInput { get; set; }

        public Type OneOutput { get; set; }

        public IInputGInputIoGIo Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo Chain(IGenericOutput other)
        {
            return this;
        }
        
        public void Execute()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
        }

        public IOutputGOutput Chain(IVoid other)
        {
            throw new NotImplementedException();
        }

        public IOutputGOutput Chain(IGenericVoid other)
        {
            throw new NotImplementedException();
        }

        public IOutputGOutput Chain<TOtherInput>(IInput<TOtherInput> other)
        {
            throw new NotImplementedException();
        }

        public IOutputGOutput Chain(IGenericInput other)
        {
            throw new NotImplementedException();
        }

        public IInputGInputIoGIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            throw new NotImplementedException();
        }

        public IInputGInputIoGIo Chain(IGenericInputOutput other)
        {
            throw new NotImplementedException();
        }
    }
}
