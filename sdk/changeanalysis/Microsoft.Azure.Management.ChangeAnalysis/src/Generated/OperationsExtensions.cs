// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.ChangeAnalysis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Operations.
    /// </summary>
    public static partial class OperationsExtensions
    {
            /// <summary>
            /// Lists all the supported operations by the Microsoft.ChangeAnalysis resource
            /// provider along with their descriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            public static IPage<ResourceProviderOperationDefinition> List(this IOperations operations, string skipToken = default(string))
            {
                return operations.ListAsync(skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the supported operations by the Microsoft.ChangeAnalysis resource
            /// provider along with their descriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceProviderOperationDefinition>> ListAsync(this IOperations operations, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the supported operations by the Microsoft.ChangeAnalysis resource
            /// provider along with their descriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceProviderOperationDefinition> ListNext(this IOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the supported operations by the Microsoft.ChangeAnalysis resource
            /// provider along with their descriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceProviderOperationDefinition>> ListNextAsync(this IOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
