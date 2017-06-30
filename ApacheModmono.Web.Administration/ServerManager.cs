namespace ApacheModmono.Web.Administration
{
	using System;
	public class ServerManager
	{
		internal SiteCollection sites = new SiteCollection();

		public ServerManager()
		{
			InitializeState();
		}

		public SiteCollection Sites
		{
			get
			{
				return sites;
			}
		}

		public void CommitChanges()
		{
			throw new NotImplementedException();
		}

		private void InitializeState()
		{
			// Virtual Directory
			var newVirtualDirectory = new VirtualDirectory();
			newVirtualDirectory.physicalPath = "/var/www/";
			// Application
			var newApplication = new Application();
			newApplication.VirtualDirectories.items.Add("/", newVirtualDirectory);
			// Binding
			var newBinding = new Binding();
			newBinding.Protocol = "https";
			newBinding.Host = "letsencrypttest.mooo.com";
			// The value of this property is a colon-delimited string that includes the IP address, port, and host name of the binding.
			newBinding.BindingInformation = "*:80:letsencrypttest.mooo.com";
			// Site
			var newSite = new Site();
			newSite.Name = "Default Web Site";
			newSite.Applications.items.Add("/", newApplication);
			newSite.Bindings.items.Add(newBinding.BindingInformation, newBinding);
			sites.items.Add(newSite.Name, newSite);
		}
	}
}

