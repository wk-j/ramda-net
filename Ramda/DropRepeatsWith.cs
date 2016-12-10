﻿// <autogenerated>
//   This file was generated by T4 code generator DropRepeatsWith.tt.
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
		public static dynamic DropRepeatsWith<TSource>(Func<TSource, TSource, bool> pred, IList<TSource> list) {
			return Currying.DropRepeatsWith(Delegate(pred), list);
		}

		public static dynamic DropRepeatsWith<TSource>(RamdaPlaceholder pred, IList<TSource> list) {
			return Currying.DropRepeatsWith(pred, list);
		}

		public static dynamic DropRepeatsWith<TSource>(Func<TSource, TSource, bool> pred, RamdaPlaceholder list = null) {
			return Currying.DropRepeatsWith(Delegate(pred), list);
		}

		public static dynamic DropRepeatsWith(dynamic pred, RamdaPlaceholder list = null) {
			return Currying.DropRepeatsWith(pred, list);
		}

		public static dynamic DropRepeatsWith<TSource>(dynamic pred, IList<TSource> list) {
			return Currying.DropRepeatsWith(pred, list);
		}

		public static dynamic DropRepeatsWith(RamdaPlaceholder pred = null, RamdaPlaceholder list = null) {
			return Currying.DropRepeatsWith(pred, list);
		}
	}
}