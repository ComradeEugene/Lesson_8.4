using System;
using static System.Console;
using System.Xml.Serialization;
using System.IO;

namespace Lesson_8._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person Petrovich = new Person() 
			{
				Address = new Address("Lenina", 19, 17),
				Phones = new Phones(89094351213, 1910722)
			};

			SerializePerson(Petrovich, "person.xml");
		}

		static void SerializePerson(Person person, string path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Person));
			using (Stream Fstream = new FileStream(path, FileMode.OpenOrCreate))
			{
				serializer.Serialize(Fstream, person);
			}
		}
	}
}
