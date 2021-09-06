// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Deployment operation parameters.
    /// </summary>
    public partial class ScopedDeployment
    {
        /// <summary>
        /// Initializes a new instance of the ScopedDeployment class.
        /// </summary>
        public ScopedDeployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScopedDeployment class.
        /// </summary>
        /// <param name="location">The location to store the deployment
        /// data.</param>
        /// <param name="properties">The deployment properties.</param>
        /// <param name="tags">Deployment tags</param>
        public ScopedDeployment(string location, DeploymentProperties properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Properties = properties;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location to store the deployment data.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets deployment tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}