﻿// <autogenerated>
//   This file was generated by T4 code generator TakeLast.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic TakeLast<TSource>(int n, IList<TSource> list) {
			return Currying.TakeLast(n, list);
		}

		public static dynamic TakeLast<TSource>(RamdaPlaceholder n, IList<TSource> list) {
			return Currying.TakeLast(n, list);
		}

		public static dynamic TakeLast(int n, RamdaPlaceholder list = null) {
			return Currying.TakeLast(n, list);
		}

		public static dynamic TakeLast(RamdaPlaceholder n = null, RamdaPlaceholder list = null) {
			return Currying.TakeLast(n, list);
		}
	}
}