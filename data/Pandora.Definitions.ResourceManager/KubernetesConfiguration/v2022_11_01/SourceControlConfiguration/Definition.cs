using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2022_11_01.SourceControlConfiguration;

internal class Definition : ResourceDefinition
{
    public string Name => "SourceControlConfiguration";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ComplianceStateTypeConstant),
        typeof(MessageLevelTypeConstant),
        typeof(OperatorScopeTypeConstant),
        typeof(OperatorTypeConstant),
        typeof(ProvisioningStateTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ComplianceStatusModel),
        typeof(HelmOperatorPropertiesModel),
        typeof(SourceControlConfigurationModel),
        typeof(SourceControlConfigurationPropertiesModel),
    };
}
