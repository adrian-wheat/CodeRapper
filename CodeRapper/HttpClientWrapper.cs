using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CodeRapper
{
    /// <summary>
    /// This class implements the <see cref="IHttpClient">IHttpClient</see> interface. 
    /// It is a wrapper class for <see cref="HttpClient">System.Net.Http.HttpClient</see>, 
    /// passing through all properties and methods straight to the HttpClient object
    /// passed through in the constructor.
    /// </summary>
    /// <remarks>
    /// Using this class instead of directly using <see cref="HttpClient">System.Net.Http.HttpClient</see> 
    /// provides the ability to unit test all calls to HttpClient via mocking the IHttpClient interface.
    /// </remarks>
    public class HttpClientWrapper : IHttpClient
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public Uri BaseAddress { get => httpClient.BaseAddress; set => httpClient.BaseAddress = value; }

        public HttpRequestHeaders DefaultRequestHeaders => httpClient.DefaultRequestHeaders;

        public long MaxResponseContentBufferSize { get => httpClient.MaxResponseContentBufferSize; set => httpClient.MaxResponseContentBufferSize = value; }
        public TimeSpan Timeout { get => httpClient.Timeout; set => httpClient.Timeout = value; }

        public void CancelPendingRequests()
        {
            httpClient.CancelPendingRequests();
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return await httpClient.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return await httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return await httpClient.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return await httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return await httpClient.GetAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return await httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return await httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return await httpClient.GetAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return await httpClient.GetAsync(requestUri, completionOption);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            return await httpClient.GetByteArrayAsync(requestUri);
        }

        public async Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            return await httpClient.GetByteArrayAsync(requestUri);
        }

        public async Task<Stream> GetStreamAsync(string requestUri)
        {
            return await httpClient.GetStreamAsync(requestUri);
        }

        public async Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return await httpClient.GetStreamAsync(requestUri);
        }

        public async Task<string> GetStringAsync(string requestUri)
        {
            return await httpClient.GetStringAsync(requestUri);
        }

        public async Task<string> GetStringAsync(Uri requestUri)
        {
            return await httpClient.GetStringAsync(requestUri);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return await httpClient.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return await httpClient.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return await httpClient.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            return await httpClient.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await httpClient.SendAsync(request);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await httpClient.SendAsync(request, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return await httpClient.SendAsync(request, completionOption);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await httpClient.SendAsync(request, completionOption, cancellationToken);
        }
    }
}
