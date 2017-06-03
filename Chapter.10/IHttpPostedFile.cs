using System.IO;

namespace Chapter._10
{
    public interface IHttpPostedFile
    {
        string FileName { get; }
        int ContentLength { get; }
        Stream InputStream { get; }
    }
}