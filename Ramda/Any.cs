﻿// <autogenerated>
//   This file was generated by T4 code generator Any.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Any<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.Any(Delegate(fn), list);
		}

		public static dynamic Any<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.Any(fn, list);
		}

		public static dynamic Any<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.Any(Delegate(fn), list);
		}

		public static dynamic Any(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.Any(fn, list);
		}

		public static dynamic Any<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.Any(fn, list);
		}

		public static dynamic Any(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.Any(fn, list);
		}
	}
}