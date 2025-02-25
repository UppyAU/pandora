using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Media.v2022_07_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2022-07-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Encodings.Definition(),
    };
}
