using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm.Model.Workers;

namespace TheFirm.Model
{
	/// <summary>
	/// Class <c>PrintAttributeAndObjectTypeValue</c> contains all the data for Workers.
	/// </summary>
	internal class PrintAttributeAndObjectTypeValue
	{
		Employee employee = new Employee("1234", "Fake", "Name");
		Manager managerA = new Manager("4567", "John", "Doe", 11223344);
		ProjectManager projectManager = new ProjectManager("9876", "Jane", "Deer", 99887766, "janeisnotadeer@.com");
		Sweeper sweeper = new Sweeper("0192", "Mary", "Sue");

		Employee manangerB = new Manager("4765", "Poly", "Morphism", 00991188);  // Using polymorphism, we can access objects of different types, through the same interface
		public void PrintAll()
		{
            Console.WriteLine("[Employee]");
            Console.WriteLine(employee.ToString());
            Console.WriteLine(string.Empty);
            Console.WriteLine("[Manager A]");
			Console.WriteLine(managerA.ToString());
			Console.WriteLine(string.Empty);
            Console.WriteLine("[Manager B]");
            Console.WriteLine(manangerB.ToString());
			Console.WriteLine(string.Empty);
			Console.WriteLine("[Project Manager]");
			Console.WriteLine(projectManager.ToString());
			Console.WriteLine(string.Empty);
			Console.WriteLine("[Sweeper]");
            Console.WriteLine(sweeper.ToString());
        }
	}
}
