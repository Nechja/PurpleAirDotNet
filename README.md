# PurpleAirDotNet
A quick wrapper for the Purple Air API
## Overview
This repository contains a C# wrapper for the [PurpleAir API](https://api.purpleair.com/), designed to make it easier to access PurpleAir's air quality monitoring data within your C# applications.


## How to use
```csharp
IHttpClient httpClient = new DefaultHttpClient();
IJsonSerializer jsonSerializer = new DefaultJsonSerializer();

PurpleAir purpleAir = new PurpleAir("YOUR_ACCESS_TOKEN_HERE", httpClient, jsonSerializer);

var data = purpleAir.GetSensorDataAsync("132705",DataFields.pm2_5,DataFields.humidity);
