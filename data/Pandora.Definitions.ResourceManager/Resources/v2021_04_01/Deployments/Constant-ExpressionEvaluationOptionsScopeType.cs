using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Resources.v2021_04_01.Deployments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExpressionEvaluationOptionsScopeTypeConstant
{
    [Description("Inner")]
    Inner,

    [Description("NotSpecified")]
    NotSpecified,

    [Description("Outer")]
    Outer,
}
