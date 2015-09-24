using System.Collections;
using System.Collections.Generic;

namespace Chapter._8
{
	public class Properties
	{
		private IDictionary _properties;
		public Properties()
		{
			_properties = new Dictionary<string, string>();
		}

		public void SetProperty(string key, string value)
		{
			_properties.Add(key, value);
		}

		public string GetProperty(string propertyKey)
		{
			var returnVal = string.Empty;

			if (_properties.Contains(propertyKey))
			{
				returnVal = _properties[propertyKey].ToString();
			}

			return returnVal;
		}
	}
}