using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8._4
{
	public struct Phones
	{
		public ulong MobilePhone { get; set; }
		public ulong FlatPhone { get; set; }

		public Phones(ulong mobilePhone, ulong flatPhone)
		{
			MobilePhone = mobilePhone;
			FlatPhone = flatPhone;
		}
	}
}
