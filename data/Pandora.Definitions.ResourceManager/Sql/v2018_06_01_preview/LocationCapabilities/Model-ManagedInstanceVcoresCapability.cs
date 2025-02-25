using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2018_06_01_preview.LocationCapabilities;


internal class ManagedInstanceVcoresCapabilityModel
{
    [JsonPropertyName("includedMaxSize")]
    public MaxSizeCapabilityModel? IncludedMaxSize { get; set; }

    [JsonPropertyName("instancePoolSupported")]
    public bool? InstancePoolSupported { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("standaloneSupported")]
    public bool? StandaloneSupported { get; set; }

    [JsonPropertyName("status")]
    public CapabilityStatusConstant? Status { get; set; }

    [JsonPropertyName("supportedStorageSizes")]
    public List<MaxSizeRangeCapabilityModel>? SupportedStorageSizes { get; set; }

    [JsonPropertyName("value")]
    public int? Value { get; set; }
}
