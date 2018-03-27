// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AvailabilitySetsOperations.
    /// </summary>
    public static partial class AvailabilitySetsOperationsExtensions
    {
            /// <summary>
            /// Create or update an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the availability set.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            public static AvailabilitySet CreateOrUpdate(this IAvailabilitySetsOperations operations, string resourceGroupName, string name, AvailabilitySet parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the availability set.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailabilitySet> CreateOrUpdateAsync(this IAvailabilitySetsOperations operations, string resourceGroupName, string name, AvailabilitySet parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static OperationStatusResponse Delete(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                return operations.DeleteAsync(resourceGroupName, availabilitySetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> DeleteAsync(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static AvailabilitySet Get(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                return operations.GetAsync(resourceGroupName, availabilitySetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailabilitySet> GetAsync(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all availability sets in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IEnumerable<AvailabilitySet> List(this IAvailabilitySetsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all availability sets in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AvailabilitySet>> ListAsync(this IAvailabilitySetsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all available virtual machine sizes that can be used to create a new
            /// virtual machine in an existing availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static IEnumerable<VirtualMachineSize> ListAvailableSizes(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                return operations.ListAvailableSizesAsync(resourceGroupName, availabilitySetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all available virtual machine sizes that can be used to create a new
            /// virtual machine in an existing availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<VirtualMachineSize>> ListAvailableSizesAsync(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableSizesWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
