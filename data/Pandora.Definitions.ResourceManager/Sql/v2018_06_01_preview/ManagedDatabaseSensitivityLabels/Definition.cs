using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2018_06_01_preview.ManagedDatabaseSensitivityLabels;

internal class Definition : ResourceDefinition
{
    public string Name => "ManagedDatabaseSensitivityLabels";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new DisableRecommendationOperation(),
        new EnableRecommendationOperation(),
        new GetOperation(),
        new ListCurrentByDatabaseOperation(),
        new ListRecommendedByDatabaseOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(SensitivityLabelRankConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SensitivityLabelModel),
        typeof(SensitivityLabelPropertiesModel),
    };
}
