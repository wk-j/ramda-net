﻿// <autogenerated>
//   This file was generated by T4 code generator DefaultTo.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic DefaultTo<TValue>(TValue a, TValue b) {
			return Currying.DefaultTo(a, b);
		}
		
		public static dynamic DefaultTo<TValue>(RamdaPlaceholder a, TValue b) {
			return Currying.DefaultTo(a, b); 
		}
		
		public static dynamic DefaultTo<TValue>(TValue a, RamdaPlaceholder b = null) {
			return Currying.DefaultTo(a, b); 
		}
		
		public static dynamic DefaultTo<TValue>(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.DefaultTo(a, b);
		}
	}
}