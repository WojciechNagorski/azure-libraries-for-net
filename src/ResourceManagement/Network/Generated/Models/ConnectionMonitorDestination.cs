// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the destination of connection monitor.
    /// </summary>
    public partial class ConnectionMonitorDestination
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorDestination
        /// class.
        /// </summary>
        public ConnectionMonitorDestination()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorDestination
        /// class.
        /// </summary>
        /// <param name="resourceId">The ID of the resource used as the
        /// destination by connection monitor.</param>
        /// <param name="address">Address of the connection monitor destination
        /// (IP or domain name).</param>
        /// <param name="port">The destination port used by connection
        /// monitor.</param>
        public ConnectionMonitorDestination(string resourceId = default(string), string address = default(string), int? port = default(int?))
        {
            ResourceId = resourceId;
            Address = address;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the resource used as the destination by
        /// connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets address of the connection monitor destination (IP or
        /// domain name).
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the destination port used by connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

    }
}