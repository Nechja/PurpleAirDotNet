using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Models;
public class ApiResponse
{
	[JsonProperty("api_version")]
	public string ApiVersion { get; set; }

	[JsonProperty("time_stamp")]
	public long? TimeStamp { get; set; }

	[JsonProperty("data_time_stamp")]
	public long? DataTimeStamp { get; set; }

	[JsonProperty("sensor")]
	public Sensor? Sensor { get; set; }
}