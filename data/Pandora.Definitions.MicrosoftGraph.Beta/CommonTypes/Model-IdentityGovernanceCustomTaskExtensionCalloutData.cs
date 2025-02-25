// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class IdentityGovernanceCustomTaskExtensionCalloutDataModel
{
    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("subject")]
    public UserModel? Subject { get; set; }

    [JsonPropertyName("task")]
    public TaskModel? Task { get; set; }

    [JsonPropertyName("taskProcessingresult")]
    public TaskProcessingResultModel? TaskProcessingresult { get; set; }

    [JsonPropertyName("workflow")]
    public WorkflowModel? Workflow { get; set; }
}
