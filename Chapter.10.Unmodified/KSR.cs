using System.Collections;
using System.Web;

namespace Chapter._10.Unmodified
{
    public class KSR
    {
        private const int MIN_LEN = 0;

        public IList GetKSRStreams(HttpFileCollection files)
        {
            ArrayList list = new ArrayList();

            foreach (string name in files)
            {
                HttpPostedFile file = files[name];

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