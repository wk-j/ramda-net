﻿// <autogenerated>
//   This file was generated by T4 code generator FromPairs.tt.
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
		public static dynamic FromPairs(object[][] pairs) {
			return Currying.FromPairs(pairs);
		}
		
		public static dynamic FromPairs(RamdaPlaceholder pairs = null) {
			return Currying.FromPairs(pairs); 
		}
	}
}