using System;
namespace ApacheModmono.Web.Administration
{
	public class Application
	{
		VirtualDirectoryCollection virtualDirectories = new VirtualDirectoryCollection();

		public Application()
		{
		}

		public VirtualDirectoryCollection VirtualDirectories
		{
			get
			{
				return virtualDirectories;
			}
		}
	}
}

