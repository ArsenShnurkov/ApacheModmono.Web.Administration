namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class BindingCollection : IEnumerable<Binding>
	{
		public BindingCollection()
		{
		}

		public Binding Add(string bindingInformation, byte[] certificateHash, string certificateStoreName)
		{
			throw new NotImplementedException();
		}

		public Binding this[string name]
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

		IEnumerator<Binding> IEnumerable<Binding>.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}

