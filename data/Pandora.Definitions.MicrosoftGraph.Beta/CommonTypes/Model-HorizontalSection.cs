// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class HorizontalSectionModel
{
    [JsonPropertyName("columns")]
    public List<HorizontalSectionColumnModel>? Columns { get; set; }

    [JsonPropertyName("emphasis")]
    public SectionEmphasisTypeConstant? Emphasis { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("layout")]
    public HorizontalSectionLayoutTypeConstant? Layout { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
