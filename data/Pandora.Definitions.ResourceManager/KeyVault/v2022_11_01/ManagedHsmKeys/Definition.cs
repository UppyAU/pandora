using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KeyVault.v2022_11_01.ManagedHsmKeys;

internal class Definition : ResourceDefinition
{
    public string Name => "ManagedHsmKeys";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateIfNotExistOperation(),
        new GetOperation(),
        new GetVersionOperation(),
        new ListOperation(),
        new ListVersionsOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DeletionRecoveryLevelConstant),
        typeof(JsonWebKeyCurveNameConstant),
        typeof(JsonWebKeyOperationConstant),
        typeof(JsonWebKeyTypeConstant),
        typeof(KeyRotationPolicyActionTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ManagedHsmActionModel),
        typeof(ManagedHsmKeyModel),
        typeof(ManagedHsmKeyAttributesModel),
        typeof(ManagedHsmKeyCreateParametersModel),
        typeof(ManagedHsmKeyPropertiesModel),
        typeof(ManagedHsmKeyReleasePolicyModel),
        typeof(ManagedHsmKeyRotationPolicyAttributesModel),
        typeof(ManagedHsmLifetimeActionModel),
        typeof(ManagedHsmRotationPolicyModel),
        typeof(ManagedHsmTriggerModel),
    };
}
