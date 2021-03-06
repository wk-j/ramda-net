﻿// <autogenerated>
//   This file was generated by T4 code generator Evolve.object.tt.
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
		/// Creates a new object by recursively evolving a shallow copy of `object`,according to the `transformation` functions. All non-primitive propertiesare copied by reference.A `transformation` function will not be invoked if its corresponding keydoes not exist in the evolved object.
		/// <para />
		/// sig: {k: (v -> v)} -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="transformations">The object specifying transformation functions to apply       to the object.</param>
		/// <param name="object">The object to be transformed.</param>
		/// <returns>The transformed object.</returns>
		public static dynamic Evolve<TTarget>(object transformations, TTarget obj) {
			return Currying.Evolve(transformations, obj);
		}

		/// <summary>
		/// Creates a new object by recursively evolving a shallow copy of `object`,according to the `transformation` functions. All non-primitive propertiesare copied by reference.A `transformation` function will not be invoked if its corresponding keydoes not exist in the evolved object.
		/// <para />
		/// sig: {k: (v -> v)} -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="transformations">The object specifying transformation functions to apply       to the object.</param>
		/// <param name="object">The object to be transformed.</param>
		/// <returns>The transformed object.</returns>
		public static dynamic Evolve(object transformations, RamdaPlaceholder obj = null) {
			return Currying.Evolve(transformations, obj);
		}
	}
}