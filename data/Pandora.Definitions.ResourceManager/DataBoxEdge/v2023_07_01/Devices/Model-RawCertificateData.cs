using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Devices;


internal class RawCertificateDataModel
{
    [JsonPropertyName("authenticationType")]
    public AuthenticationTypeConstant? AuthenticationType { get; set; }

    [JsonPropertyName("certificate")]
    [Required]
    public string Certificate { get; set; }
}
