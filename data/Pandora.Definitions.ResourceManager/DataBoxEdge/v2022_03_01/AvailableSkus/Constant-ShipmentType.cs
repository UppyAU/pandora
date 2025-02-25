using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.AvailableSkus;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ShipmentTypeConstant
{
    [Description("NotApplicable")]
    NotApplicable,

    [Description("SelfPickup")]
    SelfPickup,

    [Description("ShippedToCustomer")]
    ShippedToCustomer,
}
