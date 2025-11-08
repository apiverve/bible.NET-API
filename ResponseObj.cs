using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("book")]
        public string Book { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("chapter")]
        public int Chapter { get; set; }

        [JsonProperty("verses")]
        public int[] Verses { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
