// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class Office365ActiveUserCountsModel
{
    [JsonPropertyName("exchange")]
    public long? Exchange { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("office365")]
    public long? Office365 { get; set; }

    [JsonPropertyName("oneDrive")]
    public long? OneDrive { get; set; }

    [JsonPropertyName("reportDate")]
    public DateTime? ReportDate { get; set; }

    [JsonPropertyName("reportPeriod")]
    public string? ReportPeriod { get; set; }

    [JsonPropertyName("reportRefreshDate")]
    public DateTime? ReportRefreshDate { get; set; }

    [JsonPropertyName("sharePoint")]
    public long? SharePoint { get; set; }

    [JsonPropertyName("skypeForBusiness")]
    public long? SkypeForBusiness { get; set; }

    [JsonPropertyName("teams")]
    public long? Teams { get; set; }

    [JsonPropertyName("yammer")]
    public long? Yammer { get; set; }
}
