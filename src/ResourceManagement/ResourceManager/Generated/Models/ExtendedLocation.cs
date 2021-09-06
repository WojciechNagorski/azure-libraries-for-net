// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource extended location.
    /// </summary>
    public partial class ExtendedLocation
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        public ExtendedLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        /// <param name="type">The extended location type. Possible values
        /// include: 'EdgeZone'</param>
        /// <param name="name">The extended location name.</param>
        public ExtendedLocation(ExtendedLocationType type = default(ExtendedLocationType), string name = default(string))
        {
            Type = type;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the extended location type. Possible values include:
        /// 'EdgeZone'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ExtendedLocationType Type { get; set; }

        /// <summary>
        /// Gets or sets the extended location name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}