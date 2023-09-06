using Newtonsoft.Json;
using PurpleAirDotNet.Enums;
using PurpleAirDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Services;
public class PurpleAir
{
	private string accessToken;
	private readonly string server = "https://api.purpleair.com/";

	public PurpleAir(string accessToken) { this.accessToken = accessToken;}



	/// <summary>
	/// Asynchronously retrieves ALL sensor details based on the specified sensor ID.
	/// Be Warned this will use a lot of credits on the PurpleAir API.
	/// </summary>
	/// <param name="sensorId">The unique identifier of the sensor.</param>
	/// <returns>
	/// ApiResponse object containing the details of the sensor.
	/// </returns>
	/// <example>
	/// <code>
	/// ApiResponse response = await GetSensorAsync("132705");
	/// </code>
	/// </example>
	public async Task<ApiResponse> GetSensorAsync(string sensorId)
	{
		using (var client = new HttpClient())
		{
			client.DefaultRequestHeaders.Add("X-API-Key", accessToken);
			var response = await client.GetAsync(@$"{server}v1/sensors/{sensorId}");
			response.EnsureSuccessStatusCode();
			var apiresponce = JsonConvert.DeserializeObject<ApiResponse>(await response.Content.ReadAsStringAsync());
			return apiresponce;
			
		}
	}

	/// <summary>
	/// Retrieves sensor data with the specified data fields from the PurpleAir API.
	/// </summary>
	/// <param name="sensorId">The ID of the sensor to retrieve data for.</param>
	/// <param name="args">An array of DataFields enum values representing the fields to include in the query.</param>
	/// <exception cref="HttpRequestException">Thrown if the response is unsuccessful.</exception>
	/// <exception cref="JsonException">Thrown if the response body cannot be deserialized into an ApiResponse object.</exception>
	/// <example>
	/// <code>
	/// ApiResponse response = await GetSensorDataAsync("132705", DataFields.pm2_5, DataFields.humidity);
	/// </code>
	/// </example>
	public async Task<ApiResponse>GetSensorDataAsync(string sensorId, params DataFields[] args)
	{
		string argString = string.Join(",", args.Select(arg => arg.ToString()));

		using (var client = new HttpClient())
		{
			client.DefaultRequestHeaders.Add("X-API-Key", accessToken);
			var response = await client.GetAsync(@$"{server}v1/sensors/{sensorId}?{argString}");
			response.EnsureSuccessStatusCode();
			var apiresponce = JsonConvert.DeserializeObject<ApiResponse>(await response.Content.ReadAsStringAsync());
			return apiresponce;

		}

	}
}
