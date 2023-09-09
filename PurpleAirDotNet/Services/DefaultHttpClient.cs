namespace PurpleAirDotNet.Services;

public class DefaultHttpClient : IHttpClient
{
	private readonly HttpClient httpClient = new HttpClient();

	public void AddDefaultRequestHeader(string name, string value)
	{
		httpClient.DefaultRequestHeaders.Add(name, value);
	}

	public Task<HttpResponseMessage> GetAsync(string requestUri)
	{
		return httpClient.GetAsync(requestUri);
	}

}
