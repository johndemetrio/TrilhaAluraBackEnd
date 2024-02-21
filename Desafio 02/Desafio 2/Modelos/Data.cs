using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Desafio_2.Modelos;

public class ObjetoJson
{
    [JsonPropertyName("MRData")]
    public MRData? MRData { get; set; }
}

public class MRData
{
    [JsonPropertyName("DriverTable")]
    public DriverTable? DriverTable { get; set; }

    [JsonPropertyName("SeasonTable")]
    public SeasonTable? SeasonTable {get;set;}
    [JsonPropertyName("RaceTable")]
    public RaceTable? RaceTable {get;set;}
    public StandingsTable? StandingsTable {get;set;}
}


public class DriverTable
{
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    [JsonPropertyName("Drivers")]
    public List<Piloto>? Pilotos { get; set; }
}

public class SeasonTable
{
    [JsonPropertyName("Seasons")]
    public List<Temporada>? Temporadas {get;set;}
    [JsonPropertyName("season")]
    public string? AnoDaTemporada{get;set;}
}

public class RaceTable
{
    [JsonPropertyName("season")]
    public string? AnoDaTemporada{get;set;}
    [JsonPropertyName("Races")]
    public List<Corrida>? Corridas{get; set;}
}

public class StandingsTable
{
    [JsonPropertyName("season")]
    public string? AnoDaTemporada{get;set;}
    [JsonPropertyName("StandingsLists")]
    public List<StandingsLists>? StandingsLists {get;set;}
}

public class StandingsLists
{
    [JsonPropertyName("DriverStandings")]
    public List<ClassificacaoPiloto>? ClassificacaoPilotos { get; set; }
}