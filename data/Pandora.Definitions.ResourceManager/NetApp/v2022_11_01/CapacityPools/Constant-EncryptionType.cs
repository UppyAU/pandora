using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetApp.v2022_11_01.CapacityPools;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EncryptionTypeConstant
{
    [Description("Double")]
    Double,

    [Description("Single")]
    Single,
}
