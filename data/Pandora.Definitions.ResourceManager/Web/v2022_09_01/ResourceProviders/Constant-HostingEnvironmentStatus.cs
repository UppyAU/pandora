using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.ResourceProviders;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum HostingEnvironmentStatusConstant
{
    [Description("Deleting")]
    Deleting,

    [Description("Preparing")]
    Preparing,

    [Description("Ready")]
    Ready,

    [Description("Scaling")]
    Scaling,
}
