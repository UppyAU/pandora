using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.Provider;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProviderStackOsTypeConstant
{
    [Description("All")]
    All,

    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
