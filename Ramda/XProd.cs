﻿// <autogenerated>
//   This file was generated by T4 code generator XProd.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// Creates a new list out of the two supplied by creating each possible pairfrom the lists.
		/// <para />
		/// sig: [a] -> [b] -> [[a,b]]
		/// </summary>
		/// <param name="as">The first list.</param>
		/// <param name="bs">The second list.</param>
		/// <returns>The list made by combining each possible pair from `as` and `bs` into pairs (`[a, b]`).</returns>
		public static dynamic XProd<TSource1, TSource2>(IList<TSource1> @as, IList<TSource2> bs) {
			return Currying.XProd(@as, bs);
		}

		/// <summary>
		/// Creates a new list out of the two supplied by creating each possible pairfrom the lists.
		/// <para />
		/// sig: [a] -> [b] -> [[a,b]]
		/// </summary>
		/// <param name="as">The first list.</param>
		/// <param name="bs">The second list.</param>
		/// <returns>The list made by combining each possible pair from `as` and `bs` into pairs (`[a, b]`).</returns>
		public static dynamic XProd<TSource2>(RamdaPlaceholder @as, IList<TSource2> bs) {
			return Currying.XProd(@as, bs);
		}

		/// <summary>
		/// Creates a new list out of the two supplied by creating each possible pairfrom the lists.
		/// <para />
		/// sig: [a] -> [b] -> [[a,b]]
		/// </summary>
		/// <param name="as">The first list.</param>
		/// <param name="bs">The second list.</param>
		/// <returns>The list made by combining each possible pair from `as` and `bs` into pairs (`[a, b]`).</returns>
		public static dynamic XProd<TSource1>(IList<TSource1> @as, RamdaPlaceholder bs = null) {
			return Currying.XProd(@as, bs);
		}

		/// <summary>
		/// Creates a new list out of the two supplied by creating each possible pairfrom the lists.
		/// <para />
		/// sig: [a] -> [b] -> [[a,b]]
		/// </summary>
		/// <param name="as">The first list.</param>
		/// <param name="bs">The second list.</param>
		/// <returns>The list made by combining each possible pair from `as` and `bs` into pairs (`[a, b]`).</returns>
		public static dynamic XProd(RamdaPlaceholder @as = null, RamdaPlaceholder bs = null) {
			return Currying.XProd(@as, bs);
		}
	}
}