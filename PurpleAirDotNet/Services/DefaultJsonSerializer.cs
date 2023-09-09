using Newtonsoft.Json;

namespace PurpleAirDotNet.Services;

public class DefaultJsonSerializer : IJsonSerializer
{
	public T DeserializeObject<T>(string json)
	{
		return JsonConvert.DeserializeObject<T>(json);
	}
}