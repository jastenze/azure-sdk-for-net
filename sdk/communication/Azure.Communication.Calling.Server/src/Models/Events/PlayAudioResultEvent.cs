﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.Calling.Server
{
    /// <summary>
    /// The play audio result event.
    /// </summary>
    public partial class PlayAudioResultEvent : CallEventBase
    {
        /// <summary>
        /// The event type.
        /// </summary>
        public const string EventType = "Microsoft.Communication.PlayAudioResult";

        /// <summary>
        /// The result info.
        /// </summary>
        public ResultInfoInternal ResultInfo { get; set; }

        /// <summary>
        /// The operation context.
        /// </summary>
        public string OperationContext { get; set; }

        /// <summary>
        /// The status of the operation.
        /// </summary>
        public OperationStatusModel Status { get; set; }

        /// <summary>
        /// The call leg Id .
        /// </summary>
        public string CallLegId { get; set; }

        /// <summary> Initializes a new instance of <see cref="PlayAudioResultEvent"/>. </summary>
        /// <param name="resultInfo"> The result info. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status. </param>
        /// <param name="callLegId"> The call leg id. </param>
        public PlayAudioResultEvent(ResultInfoInternal resultInfo, string operationContext, OperationStatusModel status, string callLegId)
        {
            ResultInfo = resultInfo;
            OperationContext = operationContext;
            Status = status;
            CallLegId = callLegId;
        }
    }
}
