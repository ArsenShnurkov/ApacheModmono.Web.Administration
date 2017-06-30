using System;
namespace ApacheModmono.Web.Administration
{
	public class Site
	{
		BindingCollection bindings = new BindingCollection();
		ApplicationCollection applications = new ApplicationCollection();

		public Site()
		{
		}

		public string Name { get; set; }

		public BindingCollection Bindings
		{
			get
			{
				return bindings;
			}
		}

		public ApplicationCollection Applications
		{
			get
			{
				return applications;
			}
		}
	}
}

