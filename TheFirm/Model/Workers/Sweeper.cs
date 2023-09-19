using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model.Workers
{
	/// <summary>
	/// Class <c>Sweeper</c> inherets from Employee only, without adding any other features for itself.
	/// </summary>
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
