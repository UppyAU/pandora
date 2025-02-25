using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2021_09_01_preview.AlertRuleTemplates;


internal class MicrosoftSecurityIncidentCreationAlertRuleTemplatePropertiesModel
{
    [JsonPropertyName("alertRulesCreatedByTemplateCount")]
    [Required]
    public int AlertRulesCreatedByTemplateCount { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("createdDateUTC")]
    [Required]
    public DateTime CreatedDateUTC { get; set; }

    [JsonPropertyName("description")]
    [Required]
    public string Description { get; set; }

    [JsonPropertyName("displayName")]
    [Required]
    public string DisplayName { get; set; }

    [JsonPropertyName("displayNamesExcludeFilter")]
    public List<string>? DisplayNamesExcludeFilter { get; set; }

    [JsonPropertyName("displayNamesFilter")]
    public List<string>? DisplayNamesFilter { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("lastUpdatedDateUTC")]
    public DateTime? LastUpdatedDateUTC { get; set; }

    [JsonPropertyName("productFilter")]
    [Required]
    public MicrosoftSecurityProductNameConstant ProductFilter { get; set; }

    [JsonPropertyName("requiredDataConnectors")]
    public List<AlertRuleTemplateDataSourceModel>? RequiredDataConnectors { get; set; }

    [JsonPropertyName("severitiesFilter")]
    public List<AlertSeverityConstant>? SeveritiesFilter { get; set; }

    [JsonPropertyName("status")]
    [Required]
    public TemplateStatusConstant Status { get; set; }
}
