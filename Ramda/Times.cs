﻿// <autogenerated>
//   This file was generated by T4 code generator Times.tt.
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
		public static dynamic Times(dynamic fn, int n) {
			return Currying.Times(fn, n);
		}
			
		public static dynamic Times<TReturn>(Func<int, TReturn> fn, int n) {
			return Currying.Times(fn, n);
		}
		
		public static dynamic Times<TReturn>(RamdaPlaceholder fn, int n) {
			return Currying.Times(fn, n); 
		}

		public static dynamic Times(dynamic fn, RamdaPlaceholder n = null) {
			return Currying.Times(fn, n);
		}
		
		public static dynamic Times<TReturn>(Func<int, TReturn> fn, RamdaPlaceholder n = null) {
			return Currying.Times(fn, n); 
		}
		
		public static dynamic Times<TReturn>(RamdaPlaceholder fn = null, RamdaPlaceholder n = null) {
			return Currying.Times(fn, n);
		}
	}
}