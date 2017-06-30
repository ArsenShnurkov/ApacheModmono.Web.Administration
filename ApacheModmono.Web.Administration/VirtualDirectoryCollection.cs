namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class VirtualDirectoryCollection : IEnumerable<VirtualDirectory>
	{
		internal Dictionary<string, VirtualDirectory> items = new Dictionary<string, VirtualDirectory>();

		public VirtualDirectoryCollection()
		{
		}

		public VirtualDirectory this[string name]
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

		IEnumerator<VirtualDirectory> IEnumerable<VirtualDirectory>.GetEnumerator()
		{
			return items.Values.GetEnumerator();
		}
	}
}

