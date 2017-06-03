using System.IO;
using System.Web;

namespace Chapter._10
{
    public class HttpPostedFileWrapper : IHttpPostedFile
    {
        private HttpPostedFile _file;

        public HttpPostedFileWrapper(HttpPostedFile file)
        {
            this._file = file;
        }

        public string FileName { get => _file.FileName; }
        public int ContentLength { get => _file.ContentLength; }
        public Stream InputStream { get => _file.InputStream; }
    }
}
