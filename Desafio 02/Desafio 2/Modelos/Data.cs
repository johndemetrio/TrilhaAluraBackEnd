using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Desafio_2.Modelos;

public class ObjetoJson
{
    [JsonPropertyName("MRData")]
    public MRData MRData { get; set; }
}

public class MRData
{
    [JsonPropertyName("DriverTable")]
    public DriverTable DriverTable { get; set; }

    [JsonPropertyName("SeasonTable")]
    public SeasonTable SeasonTable {get;set;}
    [JsonPropertyName("RaceTable")]
    public RaceTable RaceTable {get;set;}
}


public class DriverTable
{
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    [JsonPropertyName("Drivers")]
    public List<Piloto> Pilotos { get; set; }
}

public class SeasonTable
{
    [JsonPropertyName("Seasons")]
    public List<Temporada> Temporadas {get;set;}
}

public class RaceTable
{
    [JsonPropertyName("season")]
    public string? Temporada{get;set;}
    [JsonPropertyName("Races")]
    public List<Corrida> Corrida{get; set;}
}