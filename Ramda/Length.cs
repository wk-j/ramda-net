﻿// <autogenerated>
//   This file was generated by T4 code generator Length.tt.
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
		public static dynamic Length<TSource>(IList<TSource> list) {
			return Currying.Length(list);
		}

		public static dynamic Length(RamdaPlaceholder list = null) {
			return Currying.Length(list);
		}
	}
}