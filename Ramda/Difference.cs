﻿// <autogenerated>
//   This file was generated by T4 code generator Difference.tt.
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
		public static dynamic Difference<TSource>(IList<TSource> list1, IList<TSource> list2) {
			return Currying.Difference(list1, list2);
		}

		public static dynamic Difference<TSource>(RamdaPlaceholder list1, IList<TSource> list2) {
			return Currying.Difference(list1, list2);
		}

		public static dynamic Difference<TSource>(IList<TSource> list1, RamdaPlaceholder list2 = null) {
			return Currying.Difference(list1, list2);
		}

		public static dynamic Difference(RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.Difference(list1, list2);
		}
	}
}