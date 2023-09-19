using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model.Workers
{
	internal class ProjectManager:Manager
	{
		protected private string _mailAddrs;

		public string MailAddrs
		{
			get { return _mailAddrs; }
			private set { _mailAddrs = value; }
		}

		protected internal ProjectManager(string socialSecurityNum, string firstName, string lastName, int phoneNum,
			string mailAddrs) : base(socialSecurityNum, firstName, lastName, phoneNum)
		{
			_mailAddrs = mailAddrs;
		}

		public override string ToString()
		{
			return $"{base.ToString()}\nMail Address: {MailAddrs}";
		}
	}
}
