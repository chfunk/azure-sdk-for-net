// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class ResourceProviderOperationsExtensions
    {
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static ResourceProviderGetResult Get(this IResourceProviderOperations operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceProviderOperations)s).GetAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Your documentation here.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<ResourceProviderGetResult> GetAsync(this IResourceProviderOperations operations, string resourceProviderNamespace)
        {
            return operations.GetAsync(resourceProviderNamespace, CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static ResourceProviderListResult List(this IResourceProviderOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceProviderOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<ResourceProviderListResult> ListAsync(this IResourceProviderOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static ResourceProviderListResult ListNext(this IResourceProviderOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceProviderOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IResourceProviderOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<ResourceProviderListResult> ListNextAsync(this IResourceProviderOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
