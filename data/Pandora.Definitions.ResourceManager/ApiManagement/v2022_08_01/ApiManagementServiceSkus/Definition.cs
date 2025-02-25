using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.ApiManagementServiceSkus;

internal class Definition : ResourceDefinition
{
    public string Name => "ApiManagementServiceSkus";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListAvailableServiceSkusOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ResourceSkuCapacityScaleTypeConstant),
        typeof(SkuTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ResourceSkuModel),
        typeof(ResourceSkuCapacityModel),
        typeof(ResourceSkuResultModel),
    };
}
