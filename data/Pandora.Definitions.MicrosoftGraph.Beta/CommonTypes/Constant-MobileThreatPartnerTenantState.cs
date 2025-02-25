// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MobileThreatPartnerTenantStateConstant
{
    [Description("Unavailable")]
    @unavailable,

    [Description("Available")]
    @available,

    [Description("Enabled")]
    @enabled,

    [Description("Unresponsive")]
    @unresponsive,
}
