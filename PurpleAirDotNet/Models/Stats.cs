using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Models;
public class Stats
{
	[JsonProperty("pm2.5")]
	public double? Pm25 { get; set; }

	[JsonProperty("pm2.5_10minute")]
	public double? Pm2510Minute { get; set; }

	[JsonProperty("pm2.5_30minute")]
	public double? Pm2530Minute { get; set; }

	[JsonProperty("pm2.5_60minute")]
	public double? Pm2560Minute { get; set; }

	[JsonProperty("pm2.5_6hour")]
	public double? Pm256Hour { get; set; }

	[JsonProperty("pm2.5_24hour")]
	public double? Pm2524Hour { get; set; }

	[JsonProperty("pm2.5_1week")]
	public double? Pm251Week { get; set; }

	[JsonProperty("time_stamp")]
	public long? TimeStamp { get; set; }
}
