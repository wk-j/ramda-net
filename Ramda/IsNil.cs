﻿// <autogenerated>
//   This file was generated by T4 code generator IsNil.tt.
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
		public static dynamic IsNil<TTarget>(TTarget x) {
			return Currying.IsNil(x);
		}
		
		public static dynamic IsNil<TTarget>(RamdaPlaceholder x = null) {
			return Currying.IsNil(x); 
		}
	}
}