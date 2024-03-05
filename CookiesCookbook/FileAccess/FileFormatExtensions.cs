namespace CookiesCookbook.FileAccess
{
    public static class FileFormatExtensions
    {
        public static string AsFileExtention(this FileFormat fileFormat) =>
            fileFormat == FileFormat.Json ? "json" : "txt";
    }
}
