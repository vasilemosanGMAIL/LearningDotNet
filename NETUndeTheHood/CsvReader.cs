namespace NETUndeTheHood
{
    internal class CsvReader
    {
        public CsvData Read(string path)
        {
            using var streamReader = new StreamReader(path);

            const string Separator = ",";
            var columns = streamReader.ReadLine().Split(Separator);

            var rows = new List<string[]>();

            while(!streamReader.EndOfStream)
            {
                var cellsInRow = streamReader.ReadLine().Split(Separator);
                rows.Add(cellsInRow);
            }

            return new CsvData(columns, rows);
        }
    }
}
