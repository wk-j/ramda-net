﻿// <autogenerated>
//   This file was generated by T4 code generator Nth.tt.
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
		public static dynamic Nth<TSource>(int offset, IEnumerable<TSource> list) {
			return Currying.Nth(offset, list);
		}
		
		public static dynamic Nth<TSource>(RamdaPlaceholder offset, IEnumerable<TSource> list) {
			return Currying.Nth(offset, list); 
		}
		
		public static dynamic Nth<TSource>(int offset, RamdaPlaceholder list = null) {
			return Currying.Nth(offset, list); 
		}
		
		public static dynamic Nth<TSource>(RamdaPlaceholder offset = null, RamdaPlaceholder list = null) {
			return Currying.Nth(offset, list);
		}
	}
}