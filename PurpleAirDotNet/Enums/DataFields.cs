using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Enums;



public enum DataFields
{
	// based of the fields from https://api.purpleair.com/
	sensor_index,
	icon,
	name,
	location_type,
	latitude,
	longitude,
	altitude,
	position,
	position_rating,
	hardware,
	firmware_version,
	rssi,
	uptime,
	pa_latency,
	last_modified,
	date_created,
	stats,
	stats_a,
	stats_b,
	humidity,
	humidity_a,
	humidity_b,
	temperature,
	pressure,
	voc,
	voc_a,
	voc_b,
	ozone1,
	scattering_coefficient,
	scattering_coefficient_a,
	scattering_coefficient_b,
	deciviews,
	deciviews_a,
	deciviews_b,
	visual_range,
	visual_range_a,
	visual_range_b,
	analog_input,
	pm2_5,
	pm2_5_10minute,
	pm2_5_30minute,
	pm2_5_60minute,
	pm2_5_6hour,
	pm2_5_24hour,
	pm2_5_1week,
	time_stamp
}
