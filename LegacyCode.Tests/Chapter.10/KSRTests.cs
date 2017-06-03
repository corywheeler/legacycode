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
        private const string filename = "testFile.ksr";
        private KSR _ksr;
        private IList _streams;

        [SetUp]
        public void Init() 
        {
            _ksr = new KSR();
            OurHttpFileCollection ourHttpFileCollection = new OurHttpFileCollection();
            ourHttpFileCollection.Add(new FakeHttpPostedFile(100, new FakeFileStream(filename, FileMode.Open), filename));
           
            _streams = _ksr.GetKSRStreams(ourHttpFileCollection);
        }

        [Test]
        public void TestWeHaveOneStream() 
        {
            Assert.AreEqual(1, _streams.Count);
        }

        private class FakeHttpPostedFile : IHttpPostedFile
        {
            private string _fileName;
            private int _fileLength;
            private Stream _stream;

			public FakeHttpPostedFile(int length, Stream stream, string name)
			{
                this._fileLength = length;
                this._stream = stream;
                this._fileName = name;
			}

            public string FileName => this._fileName;

            public int ContentLength => this._fileLength;

            public Stream InputStream => this._stream;
        }

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
