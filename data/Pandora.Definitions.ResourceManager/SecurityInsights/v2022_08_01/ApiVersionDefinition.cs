using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_08_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2022-08-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Actions.Definition(),
        new AlertRuleTemplates.Definition(),
        new AlertRules.Definition(),
        new AutomationRules.Definition(),
        new Bookmarks.Definition(),
        new DataConnectors.Definition(),
        new IncidentAlerts.Definition(),
        new IncidentBookmarks.Definition(),
        new IncidentComments.Definition(),
        new IncidentEntities.Definition(),
        new IncidentRelations.Definition(),
        new Incidents.Definition(),
        new SentinelOnboardingStates.Definition(),
        new ThreatIntelligence.Definition(),
        new WatchlistItems.Definition(),
        new Watchlists.Definition(),
    };
}
