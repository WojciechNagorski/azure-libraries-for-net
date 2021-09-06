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
    /// The resource Id model.
    /// </summary>
    public partial class ResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the ResourceReference class.
        /// </summary>
        public ResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceReference class.
        /// </summary>
        /// <param name="id">The fully qualified resource Id.</param>
        public ResourceReference(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}