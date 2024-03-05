using System.IO;

namespace NETUndeTheHood
{
    public class FileWriter : IDisposable
    {
        private readonly StreamWriter _streamWriter;
        public FileWriter(string filePath)
        {
            _streamWriter = new StreamWriter(filePath, true);
        }

        public void Write(string text)
        {
            _streamWriter.WriteLine(text);
            _streamWriter.Flush();
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }

    internal class SpecificLineFromTextFileReader : IDisposable
    {
        private readonly StreamReader _reader;
        public SpecificLineFromTextFileReader(string filePath)
        {
            _reader = new StreamReader(filePath);
        }

        public string ReadLineNumber(int lineNumber)
        {
            _reader.DiscardBufferedData();
            _reader.BaseStream.Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < lineNumber - 1; i++)
            {
                _reader.ReadLine();
            }

            return _reader.ReadLine();
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
 