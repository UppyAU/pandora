// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class PlannerPlanContextDetailsModel
{
    [JsonPropertyName("customLinkText")]
    public string? CustomLinkText { get; set; }

    [JsonPropertyName("displayLinkType")]
    public PlannerPlanContextTypeConstant? DisplayLinkType { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("state")]
    public PlannerContextStateConstant? State { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
