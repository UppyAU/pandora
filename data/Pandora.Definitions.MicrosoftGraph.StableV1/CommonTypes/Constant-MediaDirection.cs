// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MediaDirectionConstant
{
    [Description("Inactive")]
    @inactive,

    [Description("SendOnly")]
    @sendOnly,

    [Description("ReceiveOnly")]
    @receiveOnly,

    [Description("SendReceive")]
    @sendReceive,
}
