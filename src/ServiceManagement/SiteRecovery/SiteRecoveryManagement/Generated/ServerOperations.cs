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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.SiteRecovery;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of server operations for the Site Recovery extension.
    /// </summary>
    internal partial class ServerOperations : IServiceOperations<SiteRecoveryManagementClient>, IServerOperations
    {
        /// <summary>
        /// Initializes a new instance of the ServerOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ServerOperations(SiteRecoveryManagementClient client)
        {
            this._client = client;
        }
        
        private SiteRecoveryManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.SiteRecoveryManagementClient.
        /// </summary>
        public SiteRecoveryManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the server object by Id.
        /// </summary>
        /// <param name='serverId'>
        /// Required. Server ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the server object
        /// </returns>
        public async Task<ServerResponse> GetAsync(string serverId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (serverId == null)
            {
                throw new ArgumentNullException("serverId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverId", serverId);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices/";
            url = url + Uri.EscapeDataString(this.Client.CloudServiceName);
            url = url + "/resources/";
            url = url + "WAHyperVRecoveryManager";
            url = url + "/~/";
            url = url + "HyperVRecoveryManagerVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/Servers/";
            url = url + Uri.EscapeDataString(serverId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-04-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServerResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ServerResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement serverElement = responseDoc.Element(XName.Get("Server", "http://schemas.microsoft.com/windowsazure"));
                        if (serverElement != null)
                        {
                            Server serverInstance = new Server();
                            result.Server = serverInstance;
                            
                            XElement providerVersionElement = serverElement.Element(XName.Get("ProviderVersion", "http://schemas.microsoft.com/windowsazure"));
                            if (providerVersionElement != null)
                            {
                                string providerVersionInstance = providerVersionElement.Value;
                                serverInstance.ProviderVersion = providerVersionInstance;
                            }
                            
                            XElement serverVersionElement = serverElement.Element(XName.Get("ServerVersion", "http://schemas.microsoft.com/windowsazure"));
                            if (serverVersionElement != null)
                            {
                                string serverVersionInstance = serverVersionElement.Value;
                                serverInstance.ServerVersion = serverVersionInstance;
                            }
                            
                            XElement lastHeartbeatElement = serverElement.Element(XName.Get("LastHeartbeat", "http://schemas.microsoft.com/windowsazure"));
                            if (lastHeartbeatElement != null)
                            {
                                DateTime lastHeartbeatInstance = DateTime.Parse(lastHeartbeatElement.Value, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal).ToLocalTime();
                                serverInstance.LastHeartbeat = lastHeartbeatInstance;
                            }
                            
                            XElement connectedElement = serverElement.Element(XName.Get("Connected", "http://schemas.microsoft.com/windowsazure"));
                            if (connectedElement != null)
                            {
                                bool connectedInstance = bool.Parse(connectedElement.Value);
                                serverInstance.Connected = connectedInstance;
                            }
                            
                            XElement typeElement = serverElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                            if (typeElement != null)
                            {
                                string typeInstance = typeElement.Value;
                                serverInstance.Type = typeInstance;
                            }
                            
                            XElement fabricTypeElement = serverElement.Element(XName.Get("FabricType", "http://schemas.microsoft.com/windowsazure"));
                            if (fabricTypeElement != null)
                            {
                                string fabricTypeInstance = fabricTypeElement.Value;
                                serverInstance.FabricType = fabricTypeInstance;
                            }
                            
                            XElement fabricObjectIDElement = serverElement.Element(XName.Get("FabricObjectID", "http://schemas.microsoft.com/windowsazure"));
                            if (fabricObjectIDElement != null)
                            {
                                string fabricObjectIDInstance = fabricObjectIDElement.Value;
                                serverInstance.FabricObjectID = fabricObjectIDInstance;
                            }
                            
                            XElement nameElement = serverElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                serverInstance.Name = nameInstance;
                            }
                            
                            XElement idElement = serverElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                            if (idElement != null)
                            {
                                string idInstance = idElement.Value;
                                serverInstance.ID = idInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Get the list of all servers under the vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list servers operation.
        /// </returns>
        public async Task<ServerListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices/";
            url = url + Uri.EscapeDataString(this.Client.CloudServiceName);
            url = url + "/resources/";
            url = url + "WAHyperVRecoveryManager";
            url = url + "/~/";
            url = url + "HyperVRecoveryManagerVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/Servers";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-04-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServerListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ServerListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement arrayOfServerSequenceElement = responseDoc.Element(XName.Get("ArrayOfServer", "http://schemas.microsoft.com/windowsazure"));
                        if (arrayOfServerSequenceElement != null)
                        {
                            foreach (XElement arrayOfServerElement in arrayOfServerSequenceElement.Elements(XName.Get("Server", "http://schemas.microsoft.com/windowsazure")))
                            {
                                Server serverInstance = new Server();
                                result.Servers.Add(serverInstance);
                                
                                XElement providerVersionElement = arrayOfServerElement.Element(XName.Get("ProviderVersion", "http://schemas.microsoft.com/windowsazure"));
                                if (providerVersionElement != null)
                                {
                                    string providerVersionInstance = providerVersionElement.Value;
                                    serverInstance.ProviderVersion = providerVersionInstance;
                                }
                                
                                XElement serverVersionElement = arrayOfServerElement.Element(XName.Get("ServerVersion", "http://schemas.microsoft.com/windowsazure"));
                                if (serverVersionElement != null)
                                {
                                    string serverVersionInstance = serverVersionElement.Value;
                                    serverInstance.ServerVersion = serverVersionInstance;
                                }
                                
                                XElement lastHeartbeatElement = arrayOfServerElement.Element(XName.Get("LastHeartbeat", "http://schemas.microsoft.com/windowsazure"));
                                if (lastHeartbeatElement != null)
                                {
                                    DateTime lastHeartbeatInstance = DateTime.Parse(lastHeartbeatElement.Value, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal).ToLocalTime();
                                    serverInstance.LastHeartbeat = lastHeartbeatInstance;
                                }
                                
                                XElement connectedElement = arrayOfServerElement.Element(XName.Get("Connected", "http://schemas.microsoft.com/windowsazure"));
                                if (connectedElement != null)
                                {
                                    bool connectedInstance = bool.Parse(connectedElement.Value);
                                    serverInstance.Connected = connectedInstance;
                                }
                                
                                XElement typeElement = arrayOfServerElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                if (typeElement != null)
                                {
                                    string typeInstance = typeElement.Value;
                                    serverInstance.Type = typeInstance;
                                }
                                
                                XElement fabricTypeElement = arrayOfServerElement.Element(XName.Get("FabricType", "http://schemas.microsoft.com/windowsazure"));
                                if (fabricTypeElement != null)
                                {
                                    string fabricTypeInstance = fabricTypeElement.Value;
                                    serverInstance.FabricType = fabricTypeInstance;
                                }
                                
                                XElement fabricObjectIDElement = arrayOfServerElement.Element(XName.Get("FabricObjectID", "http://schemas.microsoft.com/windowsazure"));
                                if (fabricObjectIDElement != null)
                                {
                                    string fabricObjectIDInstance = fabricObjectIDElement.Value;
                                    serverInstance.FabricObjectID = fabricObjectIDInstance;
                                }
                                
                                XElement nameElement = arrayOfServerElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    serverInstance.Name = nameInstance;
                                }
                                
                                XElement idElement = arrayOfServerElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                                if (idElement != null)
                                {
                                    string idInstance = idElement.Value;
                                    serverInstance.ID = idInstance;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
