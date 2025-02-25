// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum QuarantineReasonConstant
{
    [Description("EncounteredBaseEscrowThreshold")]
    @EncounteredBaseEscrowThreshold,

    [Description("EncounteredTotalEscrowThreshold")]
    @EncounteredTotalEscrowThreshold,

    [Description("EncounteredEscrowProportionThreshold")]
    @EncounteredEscrowProportionThreshold,

    [Description("EncounteredQuarantineException")]
    @EncounteredQuarantineException,

    [Description("Unknown")]
    @Unknown,

    [Description("QuarantinedOnDemand")]
    @QuarantinedOnDemand,

    [Description("TooManyDeletes")]
    @TooManyDeletes,

    [Description("IngestionInterrupted")]
    @IngestionInterrupted,
}
