using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.NewRelic.v2022_07_01_preview;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2022-07-01-preview";
    public bool Preview => true;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Accounts.Definition(),
        new Monitors.Definition(),
        new Organizations.Definition(),
        new Plan.Definition(),
        new TagRules.Definition(),
    };
}
