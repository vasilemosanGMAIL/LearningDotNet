namespace GameDataCenter
{
    public class GameModel
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} (Release Year: {ReleaseYear}) - Rating: {Rating}";
        }
    }
}
