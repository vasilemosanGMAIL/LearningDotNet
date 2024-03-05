namespace AdvancedC_Types
{
    internal interface IApiDataReader
    {
        Task<string> Read(string baseAddress, string requestUri);
    }
}
