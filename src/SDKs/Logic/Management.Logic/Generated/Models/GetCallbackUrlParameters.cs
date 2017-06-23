// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The callback url parameters.
    /// </summary>
    public partial class GetCallbackUrlParameters
    {
        /// <summary>
        /// Initializes a new instance of the GetCallbackUrlParameters class.
        /// </summary>
        public GetCallbackUrlParameters() { }

        /// <summary>
        /// Initializes a new instance of the GetCallbackUrlParameters class.
        /// </summary>
        /// <param name="notAfter">The expiry time.</param>
        /// <param name="keyType">The key type. Possible values include:
        /// 'NotSpecified', 'Primary', 'Secondary'</param>
        public GetCallbackUrlParameters(System.DateTime? notAfter = default(System.DateTime?), KeyType? keyType = default(KeyType?))
        {
            NotAfter = notAfter;
            KeyType = keyType;
        }

        /// <summary>
        /// Gets or sets the expiry time.
        /// </summary>
        [JsonProperty(PropertyName = "notAfter")]
        public System.DateTime? NotAfter { get; set; }

        /// <summary>
        /// Gets or sets the key type. Possible values include: 'NotSpecified',
        /// 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public KeyType? KeyType { get; set; }

    }
}
