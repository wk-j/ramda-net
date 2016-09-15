﻿// <autogenerated>
//   This file was generated by T4 code generator ReduceRight.tt.
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
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(Func<TAccmulator, TSource, TResult> fn, TAccmulator acc, IEnumerable<TSource> list) {
			return Currying.ReduceRight(fn, acc, list);
		}
		
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(RamdaPlaceholder fn, TAccmulator acc, IEnumerable<TSource> list) {
			return Currying.ReduceRight(fn, acc, list); 
		}
		
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(Func<TAccmulator, TSource, TResult> fn, RamdaPlaceholder acc, IEnumerable<TSource> list) {
			return Currying.ReduceRight(fn, acc, list); 
		}
		
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(Func<TAccmulator, TSource, TResult> fn, TAccmulator acc, RamdaPlaceholder list = null) {
			return Currying.ReduceRight(fn, acc, list); 
		}
		
		
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(Func<TAccmulator, TSource, TResult> fn, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.ReduceRight(fn, acc, list);
		}
		
		public static dynamic ReduceRight<TSource, TAccmulator, TResult>(RamdaPlaceholder fn = null, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.ReduceRight(fn, acc, list);
		}
	}
}