// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class DeviceRestrictionActionModel
{
    [JsonPropertyName("action")]
    public DlpActionConstant? Action { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("restrictionAction")]
    public RestrictionActionConstant? RestrictionAction { get; set; }

    [JsonPropertyName("triggers")]
    public List<RestrictionTriggerConstant>? Triggers { get; set; }
}
