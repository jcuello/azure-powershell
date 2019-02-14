﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.StorageSync.Common
{
    /// <summary>
    /// Class HelpMessages.
    /// </summary>
    public class HelpMessages
    {
        /// <summary>
        /// As job parameter
        /// </summary>
        public const string AsJobParameter = "Run cmdlet in the background";
        /// <summary>
        /// The storage synchronize service object parameter
        /// </summary>
        public const string StorageSyncServiceObjectParameter = "StorageSyncService Object, normally passed through the parameter.";
        /// <summary>
        /// The storage synchronize service input object parameter
        /// </summary>
        public const string StorageSyncServiceInputObjectParameter = "StorageSyncService Input Object, normally passed through the pipeline.";
        /// <summary>
        /// The storage synchronize service resource identifier parameter
        /// </summary>
        public const string StorageSyncServiceResourceIdParameter = "StorageSyncService Resource Id";
        /// <summary>
        /// The storage synchronize service parent resource identifier parameter
        /// </summary>
        public const string StorageSyncServiceParentResourceIdParameter = "StorageSyncService Parent Resource Id";
        /// <summary>
        /// The storage synchronize service name parameter
        /// </summary>
        public const string StorageSyncServiceNameParameter = "Name of the StorageSyncService.";
        /// <summary>
        /// The storage synchronize service location parameter
        /// </summary>
        public const string StorageSyncServiceLocationParameter = "Storage Sync Service Location.";
        /// <summary>
        /// The storage synchronize service tags parameter
        /// </summary>
        public const string StorageSyncServiceTagsParameter = "Storage Sync Service Tags.";
        /// <summary>
        /// The storage synchronize service force parameter
        /// </summary>
        public const string StorageSyncServiceForceParameter = "Force to Delete the Storage Sync Service";
        /// <summary>
        /// The synchronize group object parameter
        /// </summary>
        public const string SyncGroupObjectParameter = "SyncGroup Object, normally passed through the parameter.";
        /// <summary>
        /// The synchronize group input object parameter
        /// </summary>
        public const string SyncGroupInputObjectParameter = "SyncGroup Input Object";
        /// <summary>
        /// The synchronize group resource identifier parameter
        /// </summary>
        public const string SyncGroupResourceIdParameter = "SyncGroup Resource Id";
        /// <summary>
        /// The synchronize group parent resource identifier parameter
        /// </summary>
        public const string SyncGroupParentResourceIdParameter = "SyncGroup Parent Resource Id";
        /// <summary>
        /// The synchronize group name parameter
        /// </summary>
        public const string SyncGroupNameParameter = "Name of the SyncGroup.";
        /// <summary>
        /// The synchronize group force parameter
        /// </summary>
        public const string SyncGroupForceParameter = "Force to Delete the Sync Group";
        /// <summary>
        /// The registered server object parameter
        /// </summary>
        public const string RegisteredServerObjectParameter = "RegisteredServer Object, normally passed through the parameter.";
        /// <summary>
        /// The registered server input object parameter
        /// </summary>
        public const string RegisteredServerInputObjectParameter = "RegisteredServer Input Object, normally passed through the pipeline.";
        /// <summary>
        /// The registered server resource identifier parameter
        /// </summary>
        public const string RegisteredServerResourceIdParameter = "RegisteredServer Resource Id";
        /// <summary>
        /// The registered server name parameter
        /// </summary>
        public const string RegisteredServerNameParameter = "Name of the RegisteredServer.";
        /// <summary>
        /// The registered server force parameter
        /// </summary>
        public const string RegisteredServerForceParameter = "Force to Delete the RegisteredServer";
        /// <summary>
        /// The cloud endpoint object parameter
        /// </summary>
        public const string CloudEndpointObjectParameter = "CloudEndpoint Object, normally passed through the parameter.";
        /// <summary>
        /// The cloud endpoint input object parameter
        /// </summary>
        public const string CloudEndpointInputObjectParameter = "CloudEndpoint Input Object, normally passed through the pipeline.";
        /// <summary>
        /// The cloud endpoint resource identifier parameter
        /// </summary>
        public const string CloudEndpointResourceIdParameter = "CloudEndpoint Resource Id";
        /// <summary>
        /// The cloud endpoint name parameter
        /// </summary>
        public const string CloudEndpointNameParameter = "Name of the CloudEndpoint.";
        /// <summary>
        /// The cloud endpoint force parameter
        /// </summary>
        public const string CloudEndpointForceParameter = "Force to Delete the CloudEndpoint";
        /// <summary>
        /// The storage account share name parameter
        /// </summary>
        public const string StorageAccountShareNameParameter = "Storage Account Share Name (Azure File Share Name)";
        /// <summary>
        /// The storage account tenant identifier parameter
        /// </summary>
        public const string StorageAccountTenantIdParameter = "Storage Account Tenant Id (Company Directory Id)";
        /// <summary>
        /// The storage account resource identifier parameter
        /// </summary>
        public const string StorageAccountResourceIdParameter = "Storage Account Resource Id";
        /// <summary>
        /// The server endpoint object parameter
        /// </summary>
        public const string ServerEndpointObjectParameter = "ServerEndpoint Object, normally passed through the parameter.";
        /// <summary>
        /// The server endpoint input object parameter
        /// </summary>
        public const string ServerEndpointInputObjectParameter = "ServerEndpoint Input Object, normally passed through the pipeline.";
        /// <summary>
        /// The server endpoint resource identifier parameter
        /// </summary>
        public const string ServerEndpointResourceIdParameter = "ServerEndpoint Resource Id";
        /// <summary>
        /// The server endpoint name parameter
        /// </summary>
        public const string ServerEndpointNameParameter = "Name of the ServerEndpoint.";
        /// <summary>
        /// The server endpoint force parameter
        /// </summary>
        public const string ServerEndpointForceParameter = "Force to Delete the ServerEndpoint";
        /// <summary>
        /// The server local path parameter
        /// </summary>
        public const string ServerLocalPathParameter = "Server Local Path Parameter";
        /// <summary>
        /// The cloud tiering parameter
        /// </summary>
        public const string CloudTieringParameter = "Cloud Tiering Parameter";
        /// <summary>
        /// The cloud seeded data parameter
        /// </summary>
        public const string CloudSeededDataParameter = "Cloud Seeded Data Parameter";
        /// <summary>
        /// The cloud seeded data file share URI parameter
        /// </summary>
        public const string CloudSeededDataFileShareUriParameter = "Cloud Seeded Data File Share Uri Parameter";
        /// <summary>
        /// The tier files older than days parameter
        /// </summary>
        public const string TierFilesOlderThanDaysParameter = "Tier Files Older Than Days Parameter";
        /// <summary>
        /// The volume free space percent parameter
        /// </summary>
        public const string VolumeFreeSpacePercentParameter = "Volume Free Space Percent Parameter";
        /// <summary>
        /// The pattern parameter
        /// </summary>
        public const string PatternParameter = "Pattern of the file name";
        /// <summary>
        /// The recall path parameter
        /// </summary>
        public const string RecallPathParameter = "Recall path which need to be recalled.";
        /// <summary>
        /// The resource group name parameter
        /// </summary>
        public const string ResourceGroupNameParameter = "Resource Group Name.";
    }
}
