using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CosmosDB.v2022_11_15.Restorables;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SpatialTypeConstant
{
    [Description("LineString")]
    LineString,

    [Description("MultiPolygon")]
    MultiPolygon,

    [Description("Point")]
    Point,

    [Description("Polygon")]
    Polygon,
}
