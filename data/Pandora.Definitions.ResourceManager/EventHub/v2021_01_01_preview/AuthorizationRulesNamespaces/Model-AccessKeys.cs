using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.AuthorizationRulesNamespaces
{

    internal class AccessKeys
    {
        [JsonPropertyName("aliasPrimaryConnectionString")]
        public string? AliasPrimaryConnectionString { get; set; }

        [JsonPropertyName("aliasSecondaryConnectionString")]
        public string? AliasSecondaryConnectionString { get; set; }

        [JsonPropertyName("keyName")]
        public string? KeyName { get; set; }

        [JsonPropertyName("primaryConnectionString")]
        public string? PrimaryConnectionString { get; set; }

        [JsonPropertyName("primaryKey")]
        public string? PrimaryKey { get; set; }

        [JsonPropertyName("secondaryConnectionString")]
        public string? SecondaryConnectionString { get; set; }

        [JsonPropertyName("secondaryKey")]
        public string? SecondaryKey { get; set; }
    }
}
