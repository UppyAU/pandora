// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class SetModel
{
    [JsonPropertyName("children")]
    public List<TermModel>? Children { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("localizedNames")]
    public List<LocalizedNameModel>? LocalizedNames { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("parentGroup")]
    public GroupModel? ParentGroup { get; set; }

    [JsonPropertyName("properties")]
    public List<KeyValueModel>? Properties { get; set; }

    [JsonPropertyName("relations")]
    public List<RelationModel>? Relations { get; set; }

    [JsonPropertyName("terms")]
    public List<TermModel>? Terms { get; set; }
}
