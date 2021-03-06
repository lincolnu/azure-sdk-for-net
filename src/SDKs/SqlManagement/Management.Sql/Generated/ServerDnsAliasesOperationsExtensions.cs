// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerDnsAliasesOperations.
    /// </summary>
    public static partial class ServerDnsAliasesOperationsExtensions
    {
            /// <summary>
            /// Gets a server DNS alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            public static ServerDnsAlias Get(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName)
            {
                return operations.GetAsync(resourceGroupName, serverName, dnsAliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a server DNS alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDnsAlias> GetAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a server dns alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            public static ServerDnsAlias CreateOrUpdate(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, dnsAliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a server dns alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDnsAlias> CreateOrUpdateAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the server DNS alias with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            public static void Delete(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, dnsAliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the server DNS alias with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of server DNS aliases for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            public static IPage<ServerDnsAlias> ListByServer(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server DNS aliases for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerDnsAlias>> ListByServerAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Acquires server DNS alias from another server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server dns alias.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static void Acquire(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, ServerDnsAliasAcquisition parameters)
            {
                operations.AcquireAsync(resourceGroupName, serverName, dnsAliasName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Acquires server DNS alias from another server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server dns alias.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AcquireAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, ServerDnsAliasAcquisition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AcquireWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a server dns alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            public static ServerDnsAlias BeginCreateOrUpdate(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, dnsAliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a server dns alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerDnsAlias> BeginCreateOrUpdateAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the server DNS alias with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            public static void BeginDelete(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, dnsAliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the server DNS alias with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server DNS alias.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Acquires server DNS alias from another server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server dns alias.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static void BeginAcquire(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, ServerDnsAliasAcquisition parameters)
            {
                operations.BeginAcquireAsync(resourceGroupName, serverName, dnsAliasName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Acquires server DNS alias from another server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server that the alias is pointing to.
            /// </param>
            /// <param name='dnsAliasName'>
            /// The name of the server dns alias.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginAcquireAsync(this IServerDnsAliasesOperations operations, string resourceGroupName, string serverName, string dnsAliasName, ServerDnsAliasAcquisition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginAcquireWithHttpMessagesAsync(resourceGroupName, serverName, dnsAliasName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of server DNS aliases for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerDnsAlias> ListByServerNext(this IServerDnsAliasesOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server DNS aliases for a server.
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
            public static async Task<IPage<ServerDnsAlias>> ListByServerNextAsync(this IServerDnsAliasesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
