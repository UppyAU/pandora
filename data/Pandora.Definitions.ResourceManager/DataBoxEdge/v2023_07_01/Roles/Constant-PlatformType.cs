using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Roles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PlatformTypeConstant
{
    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
