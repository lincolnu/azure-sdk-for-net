// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The physical server in a cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScaleUnitNode : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ScaleUnitNode class.
        /// </summary>
        public ScaleUnitNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleUnitNode class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="scaleUnitNodeStatus">Status of the physical machine.
        /// Possible values include: 'Running', 'Maintenance',
        /// 'Stopped'</param>
        /// <param name="powerState">PowerState of the physical machine.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping'</param>
        /// <param name="bmcAddress">BMC address of the physical
        /// machine.</param>
        /// <param name="scaleUnitName">Cluster name of the physical
        /// machine.</param>
        /// <param name="scaleUnitUri">URI of the corresponding
        /// cluster.</param>
        /// <param name="canPowerOff">Value indicating whether the node can be
        /// powered off.</param>
        /// <param name="vendor">Vendor of the physical machine.</param>
        /// <param name="model">Model of the physical machine.</param>
        /// <param name="serialNumber">Serial number of the physical
        /// machine.</param>
        /// <param name="biosVersion">BIOS version of the physical
        /// machine.</param>
        /// <param name="capacity">Capacity of the physical machine.</param>
        public ScaleUnitNode(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ScaleUnitNodeStatus? scaleUnitNodeStatus = default(ScaleUnitNodeStatus?), PowerState? powerState = default(PowerState?), string bmcAddress = default(string), string scaleUnitName = default(string), string scaleUnitUri = default(string), bool? canPowerOff = default(bool?), string vendor = default(string), string model = default(string), string serialNumber = default(string), string biosVersion = default(string), ScaleUnitCapacity capacity = default(ScaleUnitCapacity))
            : base(id, name, type, location, tags)
        {
            ScaleUnitNodeStatus = scaleUnitNodeStatus;
            PowerState = powerState;
            BmcAddress = bmcAddress;
            ScaleUnitName = scaleUnitName;
            ScaleUnitUri = scaleUnitUri;
            CanPowerOff = canPowerOff;
            Vendor = vendor;
            Model = model;
            SerialNumber = serialNumber;
            BiosVersion = biosVersion;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the physical machine. Possible values
        /// include: 'Running', 'Maintenance', 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnitNodeStatus")]
        public ScaleUnitNodeStatus? ScaleUnitNodeStatus { get; set; }

        /// <summary>
        /// Gets or sets powerState of the physical machine. Possible values
        /// include: 'Stopped', 'Starting', 'Running', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.powerState")]
        public PowerState? PowerState { get; set; }

        /// <summary>
        /// Gets or sets BMC address of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bmcAddress")]
        public string BmcAddress { get; set; }

        /// <summary>
        /// Gets or sets cluster name of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnitName")]
        public string ScaleUnitName { get; set; }

        /// <summary>
        /// Gets or sets URI of the corresponding cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnitUri")]
        public string ScaleUnitUri { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the node can be powered off.
        /// </summary>
        [JsonProperty(PropertyName = "properties.canPowerOff")]
        public bool? CanPowerOff { get; set; }

        /// <summary>
        /// Gets or sets vendor of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets model of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets serial number of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets BIOS version of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.biosVersion")]
        public string BiosVersion { get; set; }

        /// <summary>
        /// Gets or sets capacity of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacity")]
        public ScaleUnitCapacity Capacity { get; set; }

    }
}
