// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ExclusionGroupAssignmentTargetModel
{
    [JsonPropertyName("deviceAndAppManagementAssignmentFilterId")]
    public string? DeviceAndAppManagementAssignmentFilterId { get; set; }

    [JsonPropertyName("deviceAndAppManagementAssignmentFilterType")]
    public DeviceAndAppManagementAssignmentFilterTypeConstant? DeviceAndAppManagementAssignmentFilterType { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
