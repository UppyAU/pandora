using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_12_01.AppPlatform;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TrafficDirectionConstant
{
    [Description("Inbound")]
    Inbound,

    [Description("Outbound")]
    Outbound,
}
