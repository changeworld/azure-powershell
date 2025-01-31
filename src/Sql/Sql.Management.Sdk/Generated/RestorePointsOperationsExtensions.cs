// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RestorePointsOperations
    /// </summary>
    public static partial class RestorePointsOperationsExtensions
    {
        /// <summary>
        /// Gets a list of database restore points.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RestorePoint> ListByDatabase(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
                return ((IRestorePointsOperations)operations).ListByDatabaseAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of database restore points.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RestorePoint>> ListByDatabaseAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates a restore point for a data warehouse.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static RestorePoint Create(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, CreateDatabaseRestorePointDefinition parameters)
        {
                return ((IRestorePointsOperations)operations).CreateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a restore point for a data warehouse.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RestorePoint> CreateAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, CreateDatabaseRestorePointDefinition parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets a restore point.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='restorePointName'>
        /// The name of the restore point.
        /// </param>
        public static RestorePoint Get(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointName)
        {
                return ((IRestorePointsOperations)operations).GetAsync(resourceGroupName, serverName, databaseName, restorePointName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a restore point.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='restorePointName'>
        /// The name of the restore point.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RestorePoint> GetAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, restorePointName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes a restore point.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='restorePointName'>
        /// The name of the restore point.
        /// </param>
        public static void Delete(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointName)
        {
                ((IRestorePointsOperations)operations).DeleteAsync(resourceGroupName, serverName, databaseName, restorePointName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a restore point.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='restorePointName'>
        /// The name of the restore point.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, restorePointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Creates a restore point for a data warehouse.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static RestorePoint BeginCreate(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, CreateDatabaseRestorePointDefinition parameters)
        {
                return ((IRestorePointsOperations)operations).BeginCreateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a restore point for a data warehouse.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RestorePoint> BeginCreateAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, CreateDatabaseRestorePointDefinition parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets a list of database restore points.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RestorePoint> ListByDatabaseNext(this IRestorePointsOperations operations, string nextPageLink)
        {
                return ((IRestorePointsOperations)operations).ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of database restore points.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RestorePoint>> ListByDatabaseNextAsync(this IRestorePointsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
