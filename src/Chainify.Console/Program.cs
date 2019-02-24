using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous;
using Chainify.Synchronous.Linq;
using Chainify.Synchronous.Linq.Generic;

namespace Chainify.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new Output().Chain()
        }
    }

    public class Void : IVoid
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericVoid : IGenericVoid
    {
        public void Execute<TInput, TOutput>()
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class Input : IInput<bool>
    {
        public void Execute(bool input)
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericInput : IGenericInput
    {
        public void Execute<TInput>(TInput input)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class Output : IOutput<string>
    {
        public string Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericOutput : IGenericOutput
    {
        public TOutput Execute<TOutput>()
        {
            throw new System.NotImplementedException();
        }
    }

    public class InputOutput : IInputOutput<string, bool>
    {
        public bool Execute(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }

    public class GenericInputOutput : IGenericInputOutput
    {
        public TOutput Execute<TInput, TOutput>(TInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}
