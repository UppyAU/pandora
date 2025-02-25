using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KeyVault.v2021_10_01.ManagedHsms;

internal class Definition : ResourceDefinition
{
    public string Name => "ManagedHsms";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetDeletedOperation(),
        new ListByResourceGroupOperation(),
        new ListBySubscriptionOperation(),
        new ListDeletedOperation(),
        new PurgeDeletedOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ActionsRequiredConstant),
        typeof(CreateModeConstant),
        typeof(ManagedHsmSkuFamilyConstant),
        typeof(ManagedHsmSkuNameConstant),
        typeof(NetworkRuleActionConstant),
        typeof(NetworkRuleBypassOptionsConstant),
        typeof(PrivateEndpointConnectionProvisioningStateConstant),
        typeof(PrivateEndpointServiceConnectionStatusConstant),
        typeof(ProvisioningStateConstant),
        typeof(PublicNetworkAccessConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DeletedManagedHsmModel),
        typeof(DeletedManagedHsmPropertiesModel),
        typeof(MHSMIPRuleModel),
        typeof(MHSMNetworkRuleSetModel),
        typeof(MHSMPrivateEndpointModel),
        typeof(MHSMPrivateEndpointConnectionItemModel),
        typeof(MHSMPrivateEndpointConnectionPropertiesModel),
        typeof(MHSMPrivateLinkServiceConnectionStateModel),
        typeof(MHSMVirtualNetworkRuleModel),
        typeof(ManagedHsmModel),
        typeof(ManagedHsmPropertiesModel),
        typeof(ManagedHsmSkuModel),
    };
}
