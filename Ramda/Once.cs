﻿// <autogenerated>
//   This file was generated by T4 code generator Once.tt.
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
		public static dynamic Once<TDelegate>(TDelegate fn) {
			return Currying.Once(fn);
		}

		public static dynamic Once(RamdaPlaceholder fn = null) {
			return Currying.Once(fn);
		}
	}
}	