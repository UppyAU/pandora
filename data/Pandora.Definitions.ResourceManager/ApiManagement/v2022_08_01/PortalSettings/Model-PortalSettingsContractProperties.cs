using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.PortalSettings;


internal class PortalSettingsContractPropertiesModel
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("subscriptions")]
    public SubscriptionsDelegationSettingsPropertiesModel? Subscriptions { get; set; }

    [JsonPropertyName("termsOfService")]
    public TermsOfServicePropertiesModel? TermsOfService { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("userRegistration")]
    public RegistrationDelegationSettingsPropertiesModel? UserRegistration { get; set; }

    [JsonPropertyName("validationKey")]
    public string? ValidationKey { get; set; }
}
