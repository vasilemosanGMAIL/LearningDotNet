namespace LearningGenerics.CustomCache
{
    internal class CachingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _downloader;
        private readonly Cache<string, string> _cache = new();

        public CachingDataDownloader(IDataDownloader downloader)
        {
            _downloader = downloader;
        }

        public string DownloadData(string resourceId)
        {
            return _cache.Get(resourceId, _downloader.DownloadData);
        }
    }
}
