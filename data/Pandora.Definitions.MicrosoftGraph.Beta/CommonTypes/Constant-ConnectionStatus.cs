// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConnectionStatusConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Attempted")]
    @attempted,

    [Description("Succeeded")]
    @succeeded,

    [Description("Blocked")]
    @blocked,

    [Description("Failed")]
    @failed,
}
