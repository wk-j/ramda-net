﻿using System.Collections.Generic;
using System.Dynamic;
using static Ramda.NET.Currying;

namespace Ramda.NET
{
    public class CurryN : AbstractLambda
    {
        private readonly object[] received;

        public CurryN(DynamicDelegate fn, object[] received, int left) : base(fn, left) {
            this.received = received ?? new object[0];
        }

        protected override object TryInvoke(InvokeBinder binder, object[] arguments) {
            var argsIdx = 0;
            var left = Length;
            var combinedIdx = 0;
            var combined = new List<object>();
            var argumentsLength = Currying.Arity(arguments);

            while (combinedIdx < received.Length || argsIdx < argumentsLength) {
                object result = null;

                if (combinedIdx < received.Length && (!IsPlaceholder(received[combinedIdx]) || argsIdx >= argumentsLength)) {
                    result = received[combinedIdx];
                }
                else {
                    result = arguments[argsIdx];
                    argsIdx += 1;
                }

                combined.Insert(combinedIdx, result);

                if (!IsPlaceholder(result)) {
                    left -= 1;
                }

                combinedIdx += 1;
            }

            return left <= 0 ? fn(combined.ToArray()) : Currying.Arity(left, new CurryN(fn, combined.ToArray(), Length));
        }
    }
}
