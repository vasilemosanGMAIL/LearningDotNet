namespace AdvancedTopics
{
    internal class VideoEncoder
    {
        //3 steps for defining an event
        // 1- Define a delegate (contract between publisher and subscriber) 
        // 2- Define an event based on that delegate
        // 3- Raise the event(publish)

        //custom delegate
        //internal delegate void VideoEnodedEventHandler(object source, VideoEventArgs args);
        //internal event VideoEnodedEventHandler VideoEncoded;

        //EventHandler - built in delegate
        //EventHandler<TEventArgs> built in generic delegate
        internal event EventHandler<VideoEventArgs> VideoEncoded;

        internal void Encode(Video video)
        {
            Console.WriteLine("Encoding Video..." + video.Title);
            Thread.Sleep(2000);
            //raising the event
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs(){Video = video });
        }
    }
}
