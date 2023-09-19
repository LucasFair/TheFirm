using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model.Workers
{
	/// <summary>
	/// Class <c>Manager</c> is a class that inherets from the super class, Employees.
	/// </summary>
	internal class Manager:Employee
	{
		protected private int _phoneNum;

		public int PhoneNum
		{
			get { return _phoneNum; }
			private set { _phoneNum = value; }
		}

		protected internal Manager(string socialSecurityNum, string firstName, string lastName,
			int phoneNum) : base (socialSecurityNum, firstName, lastName)
		{
			_phoneNum = phoneNum;
		}

		public override string ToString()
		{
			return $"{base.ToString()}\nPhone Number: {PhoneNum}";
		}
	}
}
