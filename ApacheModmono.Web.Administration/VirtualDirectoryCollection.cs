namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class VirtualDirectoryCollection : IEnumerable<VirtualDirectory>
	{
		public VirtualDirectoryCollection()
		{
		}
		public VirtualDirectory this[string name]
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

		IEnumerator<VirtualDirectory> IEnumerable<VirtualDirectory>.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}

