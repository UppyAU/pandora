// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class UserInstallStateSummaryModel
{
    [JsonPropertyName("deviceStates")]
    public List<DeviceInstallStateModel>? DeviceStates { get; set; }

    [JsonPropertyName("failedDeviceCount")]
    public int? FailedDeviceCount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("installedDeviceCount")]
    public int? InstalledDeviceCount { get; set; }

    [JsonPropertyName("notInstalledDeviceCount")]
    public int? NotInstalledDeviceCount { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
