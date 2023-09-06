using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Models;
public class Sensor
{
	[JsonProperty("sensor_index")]
	public long? SensorIndex { get; set; }

	[JsonProperty("last_modified")]
	public long? LastModified { get; set; }

	[JsonProperty("date_created")]
	public long? DateCreated { get; set; }

	[JsonProperty("last_seen")]
	public long? LastSeen { get; set; }

	[JsonProperty("private")]
	public int? Private { get; set; }

	[JsonProperty("is_owner")]
	public int? IsOwner { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("icon")]
	public int? Icon { get; set; }

	[JsonProperty("location_type")]
	public int? LocationType { get; set; }

	[JsonProperty("model")]
	public string Model { get; set; }

	[JsonProperty("hardware")]
	public string Hardware { get; set; }

	[JsonProperty("led_brightness")]
	public int? LedBrightness { get; set; }

	[JsonProperty("firmware_version")]
	public string FirmwareVersion { get; set; }

	[JsonProperty("rssi")]
	public int? Rssi { get; set; }

	[JsonProperty("uptime")]
	public int? Uptime { get; set; }

	[JsonProperty("pa_latency")]
	public int? PaLatency { get; set; }

	[JsonProperty("memory")]
	public int? Memory { get; set; }

	[JsonProperty("position_rating")]
	public int? PositionRating { get; set; }

	[JsonProperty("latitude")]
	public double? Latitude { get; set; }

	[JsonProperty("longitude")]
	public double? Longitude { get; set; }

	[JsonProperty("altitude")]
	public int? Altitude { get; set; }

	[JsonProperty("channel_state")]
	public int? ChannelState { get; set; }

	[JsonProperty("channel_flags")]
	public int? ChannelFlags { get; set; }

	[JsonProperty("channel_flags_manual")]
	public int? ChannelFlagsManual { get; set; }

	[JsonProperty("channel_flags_auto")]
	public int? ChannelFlagsAuto { get; set; }

	[JsonProperty("confidence")]
	public int? Confidence { get; set; }

	[JsonProperty("confidence_auto")]
	public int? ConfidenceAuto { get; set; }

	[JsonProperty("confidence_manual")]
	public int? ConfidenceManual { get; set; }

	[JsonProperty("humidity")]
	public int? Humidity { get; set; }

	[JsonProperty("humidity_a")]
	public int? HumidityA { get; set; }

	[JsonProperty("temperature")]
	public double? Temperature { get; set; }

	[JsonProperty("temperature_a")]
	public double? TemperatureA { get; set; }

	[JsonProperty("pressure")]
	public double? Pressure { get; set; }

	[JsonProperty("pressure_a")]
	public double? PressureA { get; set; }

	[JsonProperty("analog_input")]
	public double? AnalogInput { get; set; }

	[JsonProperty("stats")]
	public Stats? Stats { get; set; }

	[JsonProperty("stats_a")]
	public Stats? StatsA { get; set; }

	[JsonProperty("stats_b")]
	public Stats? StatsB { get; set; }
}
