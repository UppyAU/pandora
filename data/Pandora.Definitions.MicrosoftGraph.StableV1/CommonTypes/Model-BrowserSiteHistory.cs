// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class BrowserSiteHistoryModel
{
    [JsonPropertyName("allowRedirect")]
    public bool? AllowRedirect { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("compatibilityMode")]
    public BrowserSiteCompatibilityModeConstant? CompatibilityMode { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public IdentitySetModel? LastModifiedBy { get; set; }

    [JsonPropertyName("mergeType")]
    public BrowserSiteMergeTypeConstant? MergeType { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("publishedDateTime")]
    public DateTime? PublishedDateTime { get; set; }

    [JsonPropertyName("targetEnvironment")]
    public BrowserSiteTargetEnvironmentConstant? TargetEnvironment { get; set; }
}
