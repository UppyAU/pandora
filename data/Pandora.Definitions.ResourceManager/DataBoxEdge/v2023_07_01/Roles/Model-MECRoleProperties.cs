using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Roles;


internal class MECRolePropertiesModel
{
    [JsonPropertyName("connectionString")]
    public AsymmetricEncryptedSecretModel? ConnectionString { get; set; }

    [JsonPropertyName("controllerEndpoint")]
    public string? ControllerEndpoint { get; set; }

    [JsonPropertyName("resourceUniqueId")]
    public string? ResourceUniqueId { get; set; }

    [JsonPropertyName("roleStatus")]
    [Required]
    public RoleStatusConstant RoleStatus { get; set; }
}
