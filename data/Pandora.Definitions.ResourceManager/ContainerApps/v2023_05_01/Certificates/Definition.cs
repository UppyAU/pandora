using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.Certificates;

internal class Definition : ResourceDefinition
{
    public string Name => "Certificates";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ConnectedEnvironmentsCertificatesCreateOrUpdateOperation(),
        new ConnectedEnvironmentsCertificatesDeleteOperation(),
        new ConnectedEnvironmentsCertificatesGetOperation(),
        new ConnectedEnvironmentsCertificatesListOperation(),
        new ConnectedEnvironmentsCertificatesUpdateOperation(),
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CertificateProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CertificateModel),
        typeof(CertificatePatchModel),
        typeof(CertificatePropertiesModel),
    };
}
