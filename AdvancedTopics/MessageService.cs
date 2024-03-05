namespace AdvancedTopics
{
    internal class MessageService
    {
        internal void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a message..." + e.Video.Title);
        }

    }
}
