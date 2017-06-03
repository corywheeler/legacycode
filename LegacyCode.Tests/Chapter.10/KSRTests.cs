using System;
using System.Collections;
using System.IO;
using Chapter._10;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._10
{
    [TestFixture]
    public class KSRTests
    {
        private KSR _ksr;
        private IList _streams;

        [SetUp]
        public void Init() 
        {
            _ksr = new KSR();
            OurHttpFileCollection ourHttpFileCollection = new OurHttpFileCollection();
            ourHttpFileCollection.Add(new FakeHttpPostedFile("testFile.ksr"));
           
            _streams = _ksr.GetKSRStreams(ourHttpFileCollection);
        }

        [Test]
        public void TestWeHaveOneStream() 
        {
            Assert.AreEqual(1, _streams.Count);
        }

        private class FakeHttpPostedFile : IHttpPostedFile
        {
            private string fileName;
            private int fileLength;
            private Stream stream;

            public FakeHttpPostedFile(string fileName)
            {
                this.fileName = fileName;
                this.fileLength = 1024;
                string fakeFilePath = string.Format("path\\{0}", fileName);
                this.stream = new FakeFileStream(fakeFilePath, FileMode.Open);
            }

            public string FileName => this.fileName;

            public int ContentLength => this.fileLength;

            public Stream InputStream => this.stream;

            private class FakeFileStream : Stream
            {
                private string fakeFilePath;
                private FileMode open;

                public FakeFileStream(string fakeFilePath, FileMode open)
                {
                    this.fakeFilePath = fakeFilePath;
                    this.open = open;
                }

                public override bool CanRead => false;

                public override bool CanSeek => false;

                public override bool CanWrite => false;

                public override long Length => 0;

                public override long Position { get; set; }

                public override void Flush()
                {
                }

                public override int Read(byte[] buffer, int offset, int count)
                {
                    return 0;
                }

                public override long Seek(long offset, SeekOrigin origin)
                {
                    return 0;
                }

                public override void SetLength(long value)
                {
                }

                public override void Write(byte[] buffer, int offset, int count)
                {
                    
                }
            }
        }


    }
}
