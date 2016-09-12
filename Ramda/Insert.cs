﻿// <autogenerated>
//   This file was generated by T4 code generator Insert.tt.
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
		public static dynamic Insert<TValue>(int index, TValue elt, IList<TValue> list) {
			return Currying.Insert(index, elt, list);
		}
		
		public static dynamic Insert<TValue>(RamdaPlaceholder index, TValue elt, IList<TValue> list) {
			return Currying.Insert(index, elt, list); 
		}
		
		public static dynamic Insert<TValue>(int index, RamdaPlaceholder elt, IList<TValue> list) {
			return Currying.Insert(index, elt, list); 
		}
		
		public static dynamic Insert<TValue>(int index, TValue elt, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list); 
		}
		
		
		public static dynamic Insert<TValue>(int index, RamdaPlaceholder elt = null, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
		
		public static dynamic Insert<TValue>(RamdaPlaceholder index = null, RamdaPlaceholder elt = null, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
	}
}