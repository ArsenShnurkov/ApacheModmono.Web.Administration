using System;
namespace ApacheModmono.Web.Administration
{
	public class VirtualDirectory
	{
		internal string physicalPath;

		public VirtualDirectory()
		{
		}

		public string PhysicalPath
		{
			get
			{
				return physicalPath;
			}
		}
	}
}

