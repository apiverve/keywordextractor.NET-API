using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("keywordCount")]
    public int keywordCount { get; set; }

    [JsonProperty("keywords")]
    public string[] keywords { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
