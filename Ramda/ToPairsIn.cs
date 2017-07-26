﻿// <autogenerated>
//   This file was generated by T4 code generator ToPairsIn.tt.
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
		/// Converts an object into an array of key, value arrays. The object's ownproperties and prototype properties are used. Note that the order of theoutput array is not guaranteed to be consistent across different JSplatforms.
		/// <para />
		/// sig: {String: *} -> [[String,*]]
		/// </summary>
		/// <param name="obj">The object to extract from</param>
		/// <returns>An array of key, value arrays from the object's own and prototype properties.</returns>
		public static dynamic ToPairsIn<TTarget>(TTarget obj) {
			return Currying.ToPairsIn(obj);
		}

		/// <summary>
		/// Converts an object into an array of key, value arrays. The object's ownproperties and prototype properties are used. Note that the order of theoutput array is not guaranteed to be consistent across different JSplatforms.
		/// <para />
		/// sig: {String: *} -> [[String,*]]
		/// </summary>
		/// <param name="obj">The object to extract from</param>
		/// <returns>An array of key, value arrays from the object's own and prototype properties.</returns>
		public static dynamic ToPairsIn(RamdaPlaceholder obj = null) {
			return Currying.ToPairsIn(obj);
		}
	}
}