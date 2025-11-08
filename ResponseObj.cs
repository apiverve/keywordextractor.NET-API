using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Keywords data
    /// </summary>
    public class Keywords
    {
        [JsonProperty("email")]
        public int Email { get; set; }

        [JsonProperty("address")]
        public int Address { get; set; }

        [JsonProperty("mail")]
        public int Mail { get; set; }

        [JsonProperty("domain")]
        public int Domain { get; set; }

        [JsonProperty("addresses")]
        public int Addresses { get; set; }

        [JsonProperty("characters")]
        public int Characters { get; set; }

        [JsonProperty("retrieved")]
        public int Retrieved { get; set; }

        [JsonProperty("internet")]
        public int Internet { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("validation")]
        public int Validation { get; set; }

        [JsonProperty("mailbox")]
        public int Mailbox { get; set; }

        [JsonProperty("errata")]
        public int Errata { get; set; }

        [JsonProperty("allowed")]
        public int Allowed { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("systems")]
        public int Systems { get; set; }

        [JsonProperty("ietf")]
        public int Ietf { get; set; }

        [JsonProperty("names")]
        public int Names { get; set; }

        [JsonProperty("user")]
        public int User { get; set; }

        [JsonProperty("protocol")]
        public int Protocol { get; set; }

        [JsonProperty("internationalized")]
        public int Internationalized { get; set; }

        [JsonProperty("solid")]
        public int Solid { get; set; }

        [JsonProperty("account")]
        public int Account { get; set; }

        [JsonProperty("addressing")]
        public int Addressing { get; set; }

        [JsonProperty("host")]
        public int Host { get; set; }

        [JsonProperty("simple")]
        public int Simple { get; set; }

        [JsonProperty("transfer")]
        public int Transfer { get; set; }

        [JsonProperty("mailboxes")]
        public int Mailboxes { get; set; }

        [JsonProperty("character")]
        public int Character { get; set; }

        [JsonProperty("quoted")]
        public int Quoted { get; set; }

        [JsonProperty("additional")]
        public int Additional { get; set; }

        [JsonProperty("syntax")]
        public int Syntax { get; set; }

        [JsonProperty("verification")]
        public int Verification { get; set; }

        [JsonProperty("form")]
        public int Form { get; set; }

        [JsonProperty("format")]
        public int Format { get; set; }

        [JsonProperty("klensin")]
        public int Klensin { get; set; }

        [JsonProperty("july")]
        public int July { get; set; }

        [JsonProperty("tools")]
        public int Tools { get; set; }

        [JsonProperty("valid")]
        public int Valid { get; set; }

        [JsonProperty("internationalization")]
        public int Internationalization { get; set; }

        [JsonProperty("group")]
        public int Group { get; set; }

        [JsonProperty("system")]
        public int System { get; set; }

        [JsonProperty("services")]
        public int Services { get; set; }

        [JsonProperty("case")]
        public int Case { get; set; }

        [JsonProperty("smtp")]
        public int Smtp { get; set; }

        [JsonProperty("ascii")]
        public int Ascii { get; set; }

        [JsonProperty("backslash")]
        public int Backslash { get; set; }

        [JsonProperty("servers")]
        public int Servers { get; set; }

        [JsonProperty("server")]
        public int Server { get; set; }

        [JsonProperty("original")]
        public int Original { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("keywords")]
        public Keywords Keywords { get; set; }

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
