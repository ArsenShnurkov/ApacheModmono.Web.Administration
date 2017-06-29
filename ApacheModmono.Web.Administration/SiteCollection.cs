namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class SiteCollection : IEnumerable<Site>
	{
		public SiteCollection()
		{
		}
		public Site this[string name]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator<Site> IEnumerable<Site>.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}

