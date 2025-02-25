using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.OperationalInsights.v2019_09_01.QueryPacks;

internal class Definition : ResourceDefinition
{
    public string Name => "QueryPacks";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new CreateOrUpdateWithoutNameOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateTagsOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(LogAnalyticsQueryPackModel),
        typeof(LogAnalyticsQueryPackPropertiesModel),
        typeof(TagsResourceModel),
    };
}
