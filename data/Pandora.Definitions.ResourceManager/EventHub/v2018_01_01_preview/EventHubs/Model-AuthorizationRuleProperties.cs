using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.EventHubs
{

    internal class AuthorizationRuleProperties
    {
        [JsonPropertyName("rights")]
        [Required]
        public List<string> Rights { get; set; }
    }
}
