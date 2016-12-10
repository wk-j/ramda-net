﻿// <autogenerated>
//   This file was generated by T4 code generator DifferenceWith.tt.
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
		public static dynamic DifferenceWith<TSource>(IList<TSource> list1, IList<TSource> list2) {
			return Currying.DifferenceWith(list1, list2);
		}

		public static dynamic DifferenceWith<TSource>(RamdaPlaceholder list1, IList<TSource> list2) {
			return Currying.DifferenceWith(list1, list2);
		}

		public static dynamic DifferenceWith<TSource>(IList<TSource> list1, RamdaPlaceholder list2 = null) {
			return Currying.DifferenceWith(list1, list2);
		}

		public static dynamic DifferenceWith(RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.DifferenceWith(list1, list2);
		}
	}
}