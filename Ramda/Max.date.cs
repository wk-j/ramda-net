﻿// <autogenerated>
//   This file was generated by T4 code generator Max.date.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Max(DateTime a, DateTime b) {
			return Currying.Max(a, b);
		}

		public static dynamic Max(RamdaPlaceholder a, DateTime b) {
			return Currying.Max(a, b);
		}

		public static dynamic Max(DateTime a, RamdaPlaceholder b = null) {
			return Currying.Max(a, b);
		}
	}
}