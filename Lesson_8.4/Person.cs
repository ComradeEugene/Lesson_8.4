using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8._4
{
	public struct Person
	{
		public Address Address { get; set; }
		public Phones Phones { get; set; }

		public Person(Address address, Phones phones)
		{
			Address = address;
			Phones = phones;
		}
	}
}