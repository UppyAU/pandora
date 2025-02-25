using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.AppServicePlans;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ManagedPipelineModeConstant
{
    [Description("Classic")]
    Classic,

    [Description("Integrated")]
    Integrated,
}
