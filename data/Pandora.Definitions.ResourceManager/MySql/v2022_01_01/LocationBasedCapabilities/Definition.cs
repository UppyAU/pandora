using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MySql.v2022_01_01.LocationBasedCapabilities;

internal class Definition : ResourceDefinition
{
    public string Name => "LocationBasedCapabilities";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CapabilityPropertiesModel),
        typeof(ServerEditionCapabilityModel),
        typeof(ServerVersionCapabilityModel),
        typeof(SkuCapabilityModel),
        typeof(StorageEditionCapabilityModel),
    };
}
