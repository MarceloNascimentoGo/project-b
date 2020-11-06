using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace project_b_webapi_bing.Models
{
    public class BingNewsResponse
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("queryContext")]
        public QueryContext QueryContext { get; set; }

        [JsonProperty("totalEstimatedMatches")]
        public long TotalEstimatedMatches { get; set; }

        [JsonProperty("sort")]
        public List<Sort> Sort { get; set; }

        [JsonProperty("value")]
        public List<Value> Value { get; set; }
    }

    public partial class QueryContext
    {
        [JsonProperty("originalQuery")]
        public string OriginalQuery { get; set; }

        [JsonProperty("adultIntent")]
        public bool AdultIntent { get; set; }
    }

    public partial class Sort
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public List<About> About { get; set; }

        [JsonProperty("provider")]
        public List<Provider> Provider { get; set; }

        [JsonProperty("datePublished")]
        public DateTimeOffset DatePublished { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }
    }

    public partial class About
    {
        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }

    public partial class Thumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class Provider
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}