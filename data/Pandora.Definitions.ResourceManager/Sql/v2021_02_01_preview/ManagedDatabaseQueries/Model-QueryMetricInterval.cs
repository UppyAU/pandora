using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2021_02_01_preview.ManagedDatabaseQueries;


internal class QueryMetricIntervalModel
{
    [JsonPropertyName("executionCount")]
    public int? ExecutionCount { get; set; }

    [JsonPropertyName("intervalStartTime")]
    public string? IntervalStartTime { get; set; }

    [JsonPropertyName("intervalType")]
    public QueryTimeGrainTypeConstant? IntervalType { get; set; }

    [JsonPropertyName("metrics")]
    public List<QueryMetricPropertiesModel>? Metrics { get; set; }
}
