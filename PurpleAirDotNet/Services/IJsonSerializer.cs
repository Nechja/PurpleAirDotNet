namespace PurpleAirDotNet.Services;

public interface IJsonSerializer
{
	T DeserializeObject<T>(string json);
}
