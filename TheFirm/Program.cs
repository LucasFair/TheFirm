using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm.Model;

namespace TheFirm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintAttributeAndObjectTypeValue printAll = new PrintAttributeAndObjectTypeValue();
			printAll.PrintAll();
		}
	}
}
