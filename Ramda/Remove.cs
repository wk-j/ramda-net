﻿// <autogenerated>
//   This file was generated by T4 code generator Remove.tt.
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
		public static dynamic Remove<TSource>(int start, int count, IList<TSource> list) {
			return Currying.Remove(start, count, list);
		}
		
		public static dynamic Remove<TSource>(RamdaPlaceholder start, int count, IList<TSource> list) {
			return Currying.Remove(start, count, list); 
		}
		
		public static dynamic Remove<TSource>(int start, RamdaPlaceholder count, IList<TSource> list) {
			return Currying.Remove(start, count, list); 
		}
		
		public static dynamic Remove<TSource>(int start, int count, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list); 
		}
		
		
		public static dynamic Remove<TSource>(int start, RamdaPlaceholder count = null, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list);
		}
		
		public static dynamic Remove<TSource>(RamdaPlaceholder start = null, RamdaPlaceholder count = null, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list);
		}
	}
}