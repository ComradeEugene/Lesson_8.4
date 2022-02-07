using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8._4
{
	public struct Address
	{
		public string Street { get; set; }
		public uint HouseNumber { get; set; }
		public uint FlatNumber { get; set; }

		public Address(string street, uint houseNumber, uint flatNumber)
		{ 
			Street = street;
			HouseNumber = houseNumber;
			FlatNumber = flatNumber;
		}
	}
}
