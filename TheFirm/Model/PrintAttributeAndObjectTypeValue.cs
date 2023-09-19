using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm.Model.Workers;

namespace TheFirm.Model
{
	internal class PrintAttributeAndObjectTypeValue
	{
		Employee employee = new Employee("1234", "Fake", "Name");
		Manager manager = new Manager("4567", "John", "Doe", 11223344);
		ProjectManager projectManager = new ProjectManager("9876", "Jane", "Deer", 99887766, "janeisnotadeer@.com");
		Sweeper sweeper = new Sweeper("0192", "Mary", "Sue");
		public void PrintAll()
		{
            Console.WriteLine("[Employee]");
            Console.WriteLine(employee.ToString());
            Console.WriteLine(string.Empty);
            Console.WriteLine("[Manager]");
			Console.WriteLine(manager.ToString());
			Console.WriteLine(string.Empty);
			Console.WriteLine("[Project Manager]");
			Console.WriteLine(projectManager.ToString());
			Console.WriteLine(string.Empty);
			Console.WriteLine("[Sweeper]");
            Console.WriteLine(sweeper.ToString());
        }
	}
}
