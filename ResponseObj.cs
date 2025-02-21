using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class keywords
{
    [JsonProperty("email")]
    public int email { get; set; }

    [JsonProperty("address")]
    public int address { get; set; }

    [JsonProperty("mail")]
    public int mail { get; set; }

    [JsonProperty("domain")]
    public int domain { get; set; }

    [JsonProperty("addresses")]
    public int addresses { get; set; }

    [JsonProperty("characters")]
    public int characters { get; set; }

    [JsonProperty("retrieved")]
    public int retrieved { get; set; }

    [JsonProperty("internet")]
    public int internet { get; set; }

    [JsonProperty("message")]
    public int message { get; set; }

    [JsonProperty("validation")]
    public int validation { get; set; }

    [JsonProperty("mailbox")]
    public int mailbox { get; set; }

    [JsonProperty("errata")]
    public int errata { get; set; }

    [JsonProperty("allowed")]
    public int allowed { get; set; }

    [JsonProperty("messages")]
    public int messages { get; set; }

    [JsonProperty("systems")]
    public int systems { get; set; }

    [JsonProperty("ietf")]
    public int ietf { get; set; }

    [JsonProperty("names")]
    public int names { get; set; }

    [JsonProperty("user")]
    public int user { get; set; }

    [JsonProperty("protocol")]
    public int protocol { get; set; }

    [JsonProperty("internationalized")]
    public int internationalized { get; set; }

    [JsonProperty("solid")]
    public int solid { get; set; }

    [JsonProperty("account")]
    public int account { get; set; }

    [JsonProperty("addressing")]
    public int addressing { get; set; }

    [JsonProperty("host")]
    public int host { get; set; }

    [JsonProperty("simple")]
    public int simple { get; set; }

    [JsonProperty("transfer")]
    public int transfer { get; set; }

    [JsonProperty("mailboxes")]
    public int mailboxes { get; set; }

    [JsonProperty("character")]
    public int character { get; set; }

    [JsonProperty("quoted")]
    public int quoted { get; set; }

    [JsonProperty("additional")]
    public int additional { get; set; }

    [JsonProperty("syntax")]
    public int syntax { get; set; }

    [JsonProperty("verification")]
    public int verification { get; set; }

    [JsonProperty("form")]
    public int form { get; set; }

    [JsonProperty("format")]
    public int format { get; set; }

    [JsonProperty("klensin")]
    public int klensin { get; set; }

    [JsonProperty("july")]
    public int july { get; set; }

    [JsonProperty("tools")]
    public int tools { get; set; }

    [JsonProperty("valid")]
    public int valid { get; set; }

    [JsonProperty("internationalization")]
    public int internationalization { get; set; }

    [JsonProperty("group")]
    public int group { get; set; }

    [JsonProperty("system")]
    public int system { get; set; }

    [JsonProperty("services")]
    public int services { get; set; }

    [JsonProperty("case")]
    public int case { get; set; }

    [JsonProperty("smtp")]
    public int smtp { get; set; }

    [JsonProperty("ascii")]
    public int ascii { get; set; }

    [JsonProperty("backslash")]
    public int backslash { get; set; }

    [JsonProperty("servers")]
    public int servers { get; set; }

    [JsonProperty("server")]
    public int server { get; set; }

    [JsonProperty("original")]
    public int original { get; set; }

    [JsonProperty("archived")]
    public int archived { get; set; }

}

public class data
{
    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("keywords")]
    public keywords keywords { get; set; }

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
