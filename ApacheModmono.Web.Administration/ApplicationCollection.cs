namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class ApplicationCollection : IEnumerable<Application>
	{
		public ApplicationCollection()
		{
		}
		public Application this[string name]
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

		IEnumerator<Application> IEnumerable<Application>.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}

