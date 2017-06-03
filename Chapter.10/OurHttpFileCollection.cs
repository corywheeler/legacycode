using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Chapter._10
{
    public class OurHttpFileCollection : NameObjectCollectionBase, IEnumerable
    {
        private Dictionary<string, IHttpPostedFile> _files = new Dictionary<string, IHttpPostedFile>();

        public IHttpPostedFile this[string key] {
            get 
            {
                return _files[key];
            }

            set
            {
                _files[key] = value;
            }
            
        }

        public void Add(IHttpPostedFile file)
        {
            _files[file.FileName] = file;
        }


        public override IEnumerator GetEnumerator()
		{
            return _files.GetEnumerator();
		}

        public new Dictionary<string, IHttpPostedFile>.KeyCollection Keys() {
            return _files.Keys;
        }
    }
}
