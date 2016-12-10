﻿// <autogenerated>
//   This file was generated by T4 code generator PropIs.tt.
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
		public static dynamic PropIs<TTarget>(Type type, string name, TTarget obj) {
			return Currying.PropIs(type, name, obj);
		}

		public static dynamic PropIs<TTarget>(RamdaPlaceholder type, string name, TTarget obj) {
			return Currying.PropIs(type, name, obj);
		}

		public static dynamic PropIs<TTarget>(Type type, RamdaPlaceholder name, TTarget obj) {
			return Currying.PropIs(type, name, obj);
		}

		public static dynamic PropIs(Type type, string name, RamdaPlaceholder obj = null) {
			return Currying.PropIs(type, name, obj);
		}

		public static dynamic PropIs(Type type, RamdaPlaceholder name = null, RamdaPlaceholder obj = null) {
			return Currying.PropIs(type, name, obj);
		}

		public static dynamic PropIs(RamdaPlaceholder type = null, RamdaPlaceholder name = null, RamdaPlaceholder obj = null) {
			return Currying.PropIs(type, name, obj);
		}
	}
}