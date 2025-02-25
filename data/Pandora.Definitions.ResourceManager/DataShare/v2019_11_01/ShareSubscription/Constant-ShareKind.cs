using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataShare.v2019_11_01.ShareSubscription;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ShareKindConstant
{
    [Description("CopyBased")]
    CopyBased,

    [Description("InPlace")]
    InPlace,
}
