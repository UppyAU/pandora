using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.SyncGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SyncGroupStateConstant
{
    [Description("Error")]
    Error,

    [Description("Good")]
    Good,

    [Description("NotReady")]
    NotReady,

    [Description("Progressing")]
    Progressing,

    [Description("Warning")]
    Warning,
}
