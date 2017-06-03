using System.Collections;

namespace Chapter._10
{
    public class KSR
    {
        private const int MIN_LEN = 0;

        public IList GetKSRStreams(OurHttpFileCollection files) 
        {
            ArrayList list = new ArrayList();
            var keys = files.Keys();

            foreach (string name in keys) 
            {
                IHttpPostedFile file = files[name];

                if (file.FileName.EndsWith(".ksr", System.StringComparison.CurrentCulture) ||
                    (file.FileName.EndsWith(".txt", System.StringComparison.CurrentCulture) && file.ContentLength > MIN_LEN))
                {
                    list.Add(file.InputStream);
                }
            }

            return list;
        }
    }
}
