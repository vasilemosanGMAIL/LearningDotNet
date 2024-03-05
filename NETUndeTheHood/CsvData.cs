namespace NETUndeTheHood
{
    internal class CsvData
    {
        public string[] Columns { get; }
        public IEnumerable<string[]> Rows { get; }

        public CsvData(string[] columns, IEnumerable<string[]> rows)
        {
            Rows = rows;
            Columns = columns;
        }
    }
}
