namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class ApplicationCollection : IEnumerable<Application>
	{
		internal Dictionary<string, Application> items = new Dictionary<string, Application>();

		public ApplicationCollection()
		{
		}

		public Application this[string name]
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

		IEnumerator<Application> IEnumerable<Application>.GetEnumerator()
		{
			return items.Values.GetEnumerator();
		}
	}
}

