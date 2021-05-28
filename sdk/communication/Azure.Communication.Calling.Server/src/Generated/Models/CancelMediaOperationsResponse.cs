// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Calling.Server
{
    /// <summary> The response payload of the cancel media processing operation. </summary>
    public partial class CancelMediaOperationsResponse
    {
        /// <summary> Initializes a new instance of CancelMediaOperationsResponse. </summary>
        internal CancelMediaOperationsResponse()
        {
        }

        /// <summary> Initializes a new instance of CancelMediaOperationsResponse. </summary>
        /// <param name="id"> Gets or sets the identifier. </param>
        /// <param name="status"> Gets or sets the status of the operation. </param>
        /// <param name="operationContext"> Gets or sets the operation context. </param>
        /// <param name="resultInfo"> Gets or sets the result info. </param>
        internal CancelMediaOperationsResponse(string id, OperationStatusModel? status, string operationContext, ResultInfoInternal resultInfo)
        {
            Id = id;
            Status = status;
            OperationContext = operationContext;
            ResultInfo = resultInfo;
        }

        /// <summary> Gets or sets the identifier. </summary>
        public string Id { get; }
        /// <summary> Gets or sets the status of the operation. </summary>
        public OperationStatusModel? Status { get; }
        /// <summary> Gets or sets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets or sets the result info. </summary>
        public ResultInfoInternal ResultInfo { get; }
    }
}
