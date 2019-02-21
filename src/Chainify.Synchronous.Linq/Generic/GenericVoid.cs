using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Generic.Void;

namespace Chainify.Synchronous.Linq.Generic
{
    public static class GenericVoid
    {
        public static IGOutputOutput Chain(this IGenericVoid instance, IGenericVoid other)
        {
            return new GenericVoidBuilder();
        }
        
        public static IGOutputOutput Chain(this IGenericVoid instance, IVoid other)
        {
            return new GenericVoidBuilder();
        }

        public static IGInputInputGIoIo Chain(this IGenericVoid instance, IGenericOutput other)
        {
            return new GenericVoidBuilder();
        }
        
        public static IGInputInputGIoIo Chain<TOtherOutput>(this IGenericVoid instance, IOutput<TOtherOutput> other)
        {
            return new GenericVoidBuilder();
        }        
    }
}
