using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model.Workers
{
	internal class Employee
	{
		protected private string _socialSecurityNum;
		protected private string _firstName;
		protected private string _lastName;

		public string SocialSecurityNum
		{
			get { return _socialSecurityNum; }
			private set { _socialSecurityNum = value; }
		}
		public string FirstName
		{
			get { return _firstName; }
			private set { _firstName = value; }
		}
		public string LastName
		{
			get { return _lastName; }
			private set { _lastName = value; }
		}

		protected internal Employee(string socialSecurityNum, string firstName, string lastName)
		{
			_socialSecurityNum = socialSecurityNum;
			_firstName = firstName;
			_lastName = lastName;
		}

		public override string ToString()
		{
			return $"Social Security Number: {SocialSecurityNum}\nFirst Name: {FirstName}\nLast Name: {LastName}";
		}
	}
}
