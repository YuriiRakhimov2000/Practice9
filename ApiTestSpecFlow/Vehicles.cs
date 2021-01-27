using System;
using Newtonsoft.Json;

namespace ApiTestSpecFlow
{
    public class Vehicles
    {
        [JsonProperty("count", Required = Required.Always)]
        public long Count { get; set; }

        [JsonProperty("next", Required = Required.Always)]
        public Uri Next { get; set; }

        [JsonProperty("previous", Required = Required.AllowNull)]
        public Uri? Previous { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public VehiclesResult[] Results { get; set; }
    }

    public class VehiclesResult
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("model", Required = Required.Always)]
        public string Model { get; set; }

        [JsonProperty("manufacturer", Required = Required.Always)]
        public string Manufacturer { get; set; }

        [JsonProperty("cost_in_credits", Required = Required.Always)]
        public string Cost_in_credits { get; set; }

        [JsonProperty("length", Required = Required.Always)]
        public string Length { get; set; }

        [JsonProperty("max_atmosphering_speed", Required = Required.Always)]
        public string Max_atmosphering_speed { get; set; }

        [JsonProperty("crew", Required = Required.Always)]
        public string Crew { get; set; }

        [JsonProperty("passengers", Required = Required.Always)]
        public string Passengers { get; set; }

        [JsonProperty("cargo_capacity", Required = Required.Always)]
        public Uri Cargo_capacity { get; set; }

        [JsonProperty("consumables", Required = Required.Always)]
        public string Consumables { get; set; }

        [JsonProperty("vehicle_class", Required = Required.Always)]
        public string Vehicle_class { get; set; }

        [JsonProperty("pilots", Required = Required.Always)]
        public Uri[] Pilots { get; set; }

        [JsonProperty("films", Required = Required.Always)]
        public Uri[] Films { get; set; }

        [JsonProperty("created", Required = Required.Always)]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("edited", Required = Required.Always)]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("url", Required = Required.Always)]
        public Uri Url { get; set; }
    }
}
