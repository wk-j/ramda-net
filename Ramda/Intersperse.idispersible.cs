﻿// <autogenerated>
//   This file was generated by T4 code generator Intersperse.idispersible.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
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
		/// Creates a new list with the separator interposed between elements.Dispatches to the `intersperse` method of the second argument, if present.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="separator">The element to add to the list.</param>
		/// <param name="list">The list to be interposed.</param>
		/// <returns>The new list.</returns>
		public static dynamic Intersperse<TResult, TSeperator>(TSeperator separator, IDispersible<TSeperator, TResult> list) {
			return Currying.Intersperse(separator, list);
		}

		/// <summary>
		/// Creates a new list with the separator interposed between elements.Dispatches to the `intersperse` method of the second argument, if present.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="separator">The element to add to the list.</param>
		/// <param name="list">The list to be interposed.</param>
		/// <returns>The new list.</returns>
		public static dynamic Intersperse<TResult, TSeperator>(RamdaPlaceholder separator, IDispersible<TSeperator, TResult> list) {
			return Currying.Intersperse(separator, list);
		}
	}
}