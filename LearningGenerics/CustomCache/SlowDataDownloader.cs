namespace LearningGenerics.CustomCache
{
    internal class SlowDataDownloader : IDataDownloader
    {
        string IDataDownloader.DownloadData(string resourceId)
        {
            //let's imagine this method downloads real data,
            //and it does it dlowly
            Thread.Sleep(1000);
            return $"Some data for {resourceId}";
        }
    }
}
