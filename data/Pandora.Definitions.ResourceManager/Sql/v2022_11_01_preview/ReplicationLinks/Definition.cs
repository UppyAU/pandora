using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.ReplicationLinks;

internal class Definition : ResourceDefinition
{
    public string Name => "ReplicationLinks";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteOperation(),
        new FailoverOperation(),
        new FailoverAllowDataLossOperation(),
        new GetOperation(),
        new ListByDatabaseOperation(),
        new ListByServerOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ReplicationLinkTypeConstant),
        typeof(ReplicationRoleConstant),
        typeof(ReplicationStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ReplicationLinkModel),
        typeof(ReplicationLinkPropertiesModel),
    };
}
