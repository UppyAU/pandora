using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.PerformConnectivityCheck;


internal class ConnectivityCheckRequestModel
{
    [JsonPropertyName("destination")]
    [Required]
    public ConnectivityCheckRequestDestinationModel Destination { get; set; }

    [JsonPropertyName("preferredIPVersion")]
    public PreferredIPVersionConstant? PreferredIPVersion { get; set; }

    [JsonPropertyName("protocol")]
    public ConnectivityCheckProtocolConstant? Protocol { get; set; }

    [JsonPropertyName("protocolConfiguration")]
    public ConnectivityCheckRequestProtocolConfigurationModel? ProtocolConfiguration { get; set; }

    [JsonPropertyName("source")]
    [Required]
    public ConnectivityCheckRequestSourceModel Source { get; set; }
}
