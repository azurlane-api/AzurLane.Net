#nullable enable

namespace AzurLane.Net.Core
{
    public interface IBaseResponse
    {
        int StatusCode { get; }
        string StatusMessage { get; }
        string Message { get; }
    }

    public interface IErrorResponse : IBaseResponse
    {
        string? Error { get; }
    }
}