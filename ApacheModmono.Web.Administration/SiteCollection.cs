namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class SiteCollection : IEnumerable<Site>
	{
		internal Dictionary<string, Site> items = new Dictionary<string, Site>();

		public SiteCollection()
		{
		}

		public Site this[string name]
		{
			get
			{
				return items[name];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return items.Values.GetEnumerator();
		}

		IEnumerator<Site> IEnumerable<Site>.GetEnumerator()
		{
			return items.Values.GetEnumerator();
		}
	}
}

