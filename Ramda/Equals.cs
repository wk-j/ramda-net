﻿// <autogenerated>
//   This file was generated by T4 code generator Equals.tt.
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
		public static dynamic Equals<TTArget1, TTArget2>(TTArget1 a, TTArget2 b) {
			return Currying.Equals(a, b);
		}

		public static dynamic Equals<TTArget2>(RamdaPlaceholder a, TTArget2 b) {
			return Currying.Equals(a, b);
		}

		public static dynamic Equals<TTArget1>(TTArget1 a, RamdaPlaceholder b = null) {
			return Currying.Equals(a, b);
		}

		public static dynamic Equals(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.Equals(a, b);
		}
	}
}