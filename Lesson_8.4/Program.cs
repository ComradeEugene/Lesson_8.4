using System;
using static System.Console;
using System.Xml.Linq;

namespace Lesson_8._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WriteLine("ФИО:");
			string Person = ReadLine();
			WriteLine("Улица:");
			string Street = ReadLine();
			WriteLine("Номер дома:");
			uint HouseNumber = uint.Parse(ReadLine());
			WriteLine("Номер квартиры:");
			uint FlatNumber = uint.Parse(ReadLine());
			WriteLine("Мобильный телефон:");
			string MobilePhone = ReadLine();
			WriteLine("Домашний телефон:");
			string FlatPhone = ReadLine();

			XElement Contact = new XElement("Person");
			XAttribute Name = new XAttribute("name", Person);
			Contact.Add(Name);

			XElement Add = new XElement("Address");
			XElement Str = new XElement("Street", Street);
			XElement HouseNum = new XElement("HouseNumber", HouseNumber);
			XElement FlatNum = new XElement("FlatNumber", FlatNumber);
			Add.Add(Str, HouseNum, FlatNum);
			Contact.Add(Add);

			XElement Phones = new XElement("Phones");
			XElement Mobile = new XElement("MobilePhone", MobilePhone);
			XElement FlatPh = new XElement("FlatPhone", FlatPhone);
			Phones.Add(Mobile, FlatPh);
			Contact.Add(Phones);

			Contact.Save("person.xml");
		}
	}
}
