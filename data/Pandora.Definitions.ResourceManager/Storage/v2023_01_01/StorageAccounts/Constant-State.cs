using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.StorageAccounts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StateConstant
{
    [Description("Deprovisioning")]
    Deprovisioning,

    [Description("Failed")]
    Failed,

    [Description("NetworkSourceDeleted")]
    NetworkSourceDeleted,

    [Description("Provisioning")]
    Provisioning,

    [Description("Succeeded")]
    Succeeded,
}
