namespace PurpleAirDotNet.Services;

public interface IHttpClient
{
	Task<HttpResponseMessage> GetAsync(string requestUri);
	void AddDefaultRequestHeader(string name, string value);
}
