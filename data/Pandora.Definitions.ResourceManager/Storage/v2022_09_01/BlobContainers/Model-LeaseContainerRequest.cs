using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2022_09_01.BlobContainers;


internal class LeaseContainerRequestModel
{
    [JsonPropertyName("action")]
    [Required]
    public LeaseContainerRequestActionConstant Action { get; set; }

    [JsonPropertyName("breakPeriod")]
    public int? BreakPeriod { get; set; }

    [JsonPropertyName("leaseDuration")]
    public int? LeaseDuration { get; set; }

    [JsonPropertyName("leaseId")]
    public string? LeaseId { get; set; }

    [JsonPropertyName("proposedLeaseId")]
    public string? ProposedLeaseId { get; set; }
}
