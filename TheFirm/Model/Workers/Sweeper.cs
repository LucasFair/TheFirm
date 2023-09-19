using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model.Workers
{
	internal class Sweeper:Employee
	{

		protected internal Sweeper(string socialSecurityNum, string firstName, string lastName) : base(socialSecurityNum, firstName, lastName)
		{
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
