using System;
namespace ApacheModmono.Web.Administration
{
	public class Binding
	{
		public Binding()
		{
		}

		public string Host { get; set; }

		public string Protocol { get; set; }

		public string BindingInformation { get; set; }

		public byte[] CertificateHash
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string CertificateStoreName { get; set; }
	}
}

