using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.WebApps;

internal class StartWebSiteNetworkTraceOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new AppServiceId();

    public override Type? ResponseObject() => typeof(string);

    public override Type? OptionsObject() => typeof(StartWebSiteNetworkTraceOperation.StartWebSiteNetworkTraceOptions);

    public override string? UriSuffix() => "/networkTrace/start";

    internal class StartWebSiteNetworkTraceOptions
    {
        [QueryStringName("durationInSeconds")]
        [Optional]
        public int DurationInSeconds { get; set; }

        [QueryStringName("maxFrameLength")]
        [Optional]
        public int MaxFrameLength { get; set; }

        [QueryStringName("sasUrl")]
        [Optional]
        public string SasUrl { get; set; }
    }
}
