using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.RestorePointCollections;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperatingSystemTypeConstant
{
    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
