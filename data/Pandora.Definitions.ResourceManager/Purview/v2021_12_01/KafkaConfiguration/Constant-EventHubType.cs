using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_12_01.KafkaConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EventHubTypeConstant
{
    [Description("Hook")]
    Hook,

    [Description("Notification")]
    Notification,
}
