using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Void;

namespace Chainify.Synchronous.Linq
{
    public static class Void
    {
        public static IOutputGOutput Chain(this IVoid instance, IVoid other)
        {
            return new VoidBuilder();
        }

        public static IOutputGOutput Chain(this IVoid instance, IGenericVoid other)
        {
            throw new NotImplementedException();
        }

        public static IInputGInputIoGIo Chain<TOtherOutput>(this IVoid instance, IOutput<TOtherOutput> other)
        {
            return new VoidBuilder();
        }

        public static IInputGInputIoGIo Chain(this IVoid instance, IGenericOutput other)
        {
            throw new NotImplementedException();
        }
    }
}
