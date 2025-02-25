using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2020_05_01.PrivateLinkAssociation;

internal class PutOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(PrivateLinkAssociationObjectModel);

    public override ResourceID? ResourceId() => new PrivateLinkAssociationId();

    public override Type? ResponseObject() => typeof(PrivateLinkAssociationModel);


}
