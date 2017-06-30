namespace ApacheModmono.Web.Administration
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class BindingCollection : IEnumerable<Binding>
	{
		internal Dictionary<string, Binding> items = new Dictionary<string, Binding>();

		public BindingCollection()
		{
		}

		public Binding this[string name]
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

		IEnumerator<Binding> IEnumerable<Binding>.GetEnumerator()
		{
			return items.Values.GetEnumerator();
		}

		public Binding Add(string bindingInformation, byte[] certificateHash, string certificateStoreName)
		{
			throw new NotImplementedException();
		}
	}
}

