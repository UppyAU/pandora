using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2021_09_03_preview.ApplicationGroup;


internal class MigrationRequestPropertiesModel
{
    [JsonPropertyName("migrationPath")]
    public string? MigrationPath { get; set; }

    [JsonPropertyName("operation")]
    public OperationConstant? Operation { get; set; }
}
