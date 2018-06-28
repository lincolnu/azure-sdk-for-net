// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This resource represents an IP Address.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PublicIpAddress : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PublicIpAddress class.
        /// </summary>
        public PublicIpAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIpAddress class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <param name="tenantResourceUri">The tenant resource URI.</param>
        /// <param name="ipAddress">The IP address.</param>
        /// <param name="ipPool">The IP pool.</param>
        /// <param name="allocationMethod">The allocation method. Possible
        /// values include: 'Dynamic', 'Static'</param>
        public PublicIpAddress(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string subscriptionId = default(string), string tenantResourceUri = default(string), string ipAddress = default(string), string ipPool = default(string), string allocationMethod = default(string))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            SubscriptionId = subscriptionId;
            TenantResourceUri = tenantResourceUri;
            IpAddress = ipAddress;
            IpPool = ipPool;
            AllocationMethod = allocationMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the subscription ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the tenant resource URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantResourceUri")]
        public string TenantResourceUri { get; private set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the IP pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipPool")]
        public string IpPool { get; set; }

        /// <summary>
        /// Gets or sets the allocation method. Possible values include:
        /// 'Dynamic', 'Static'
        /// </summary>
        [JsonProperty(PropertyName = "properties.allocationMethod")]
        public string AllocationMethod { get; set; }

    }
}