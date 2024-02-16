using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Desafio_2.Modelos;

public class JsonObject
{
    [JsonPropertyName("MRData")]
    public MRData MRData { get; set; }
}

public class MRData
{
    [JsonPropertyName("DriverTable")]
    public DriverTable DriverTable { get; set; }
}


public class DriverTable
{
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    [JsonPropertyName("Drivers")]
    public List<Driver> Drivers { get; set; }
}
