using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataFactory.v2018_06_01.DataFlowDebugSession;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DataFlowDebugCommandTypeConstant
{
    [Description("executeExpressionQuery")]
    ExecuteExpressionQuery,

    [Description("executePreviewQuery")]
    ExecutePreviewQuery,

    [Description("executeStatisticsQuery")]
    ExecuteStatisticsQuery,
}
