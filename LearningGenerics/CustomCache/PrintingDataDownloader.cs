namespace LearningGenerics.CustomCache
{
    internal class PrintingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _downloader;
        private readonly Cache<string, string> _cache = new();

        public PrintingDataDownloader(IDataDownloader downloader)
        {
            _downloader = downloader;
        }

        public string DownloadData(string resourceId)
        {
            var data = _downloader.DownloadData(resourceId);
            Console.WriteLine("Data is ready!");
            return data;
        }
    }
}