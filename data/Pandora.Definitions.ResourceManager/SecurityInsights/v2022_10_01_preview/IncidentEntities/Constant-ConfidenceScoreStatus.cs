using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.IncidentEntities;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConfidenceScoreStatusConstant
{
    [Description("Final")]
    Final,

    [Description("InProcess")]
    InProcess,

    [Description("NotApplicable")]
    NotApplicable,

    [Description("NotFinal")]
    NotFinal,
}
