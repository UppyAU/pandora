// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SubjectRightsRequestStageStatusConstant
{
    [Description("NotStarted")]
    @notStarted,

    [Description("Current")]
    @current,

    [Description("Completed")]
    @completed,

    [Description("Failed")]
    @failed,
}
