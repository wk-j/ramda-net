﻿// <autogenerated>
//   This file was generated by T4 code generator PropOr.tt.
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
		public static dynamic PropOr<TValue, TTarget>(TValue val, IList<string> p, TTarget obj) {
			return Currying.PropOr(val, p, obj);
		}
		
		public static dynamic PropOr<TValue, TTarget>(RamdaPlaceholder val, IList<string> p, TTarget obj) {
			return Currying.PropOr(val, p, obj); 
		}
		
		public static dynamic PropOr<TValue, TTarget>(TValue val, RamdaPlaceholder p, TTarget obj) {
			return Currying.PropOr(val, p, obj); 
		}
		
		public static dynamic PropOr<TValue, TTarget>(TValue val, IList<string> p, RamdaPlaceholder obj = null) {
			return Currying.PropOr(val, p, obj); 
		}
		
		
		public static dynamic PropOr<TValue, TTarget>(TValue val, RamdaPlaceholder p = null, RamdaPlaceholder obj = null) {
			return Currying.PropOr(val, p, obj);
		}
		
		public static dynamic PropOr<TValue, TTarget>(RamdaPlaceholder val = null, RamdaPlaceholder p = null, RamdaPlaceholder obj = null) {
			return Currying.PropOr(val, p, obj);
		}
	}
}