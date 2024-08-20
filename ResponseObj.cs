using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("book")]
    public string book { get; set; }

    [JsonProperty("abbr")]
    public string abbr { get; set; }

    [JsonProperty("chapter")]
    public int chapter { get; set; }

    [JsonProperty("verses")]
    public int[] verses { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
