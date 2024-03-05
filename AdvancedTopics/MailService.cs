namespace AdvancedTopics
{
    internal class MailService
    {
        internal void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}
