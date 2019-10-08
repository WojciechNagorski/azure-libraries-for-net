// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB SQL database.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDatabaseInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabaseInner class.
        /// </summary>
        public SqlDatabaseInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabaseInner class.
        /// </summary>
        /// <param name="sqlDatabaseId">Name of the Cosmos DB SQL
        /// database</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        /// <param name="_colls">A system generated property that specified the
        /// addressable path of the collections resource.</param>
        /// <param name="_users">A system generated property that specifies the
        /// addressable path of the users resource.</param>
        public SqlDatabaseInner(string sqlDatabaseId, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string _rid = default(string), object _ts = default(object), string _etag = default(string), string _colls = default(string), string _users = default(string))
            : base(location, id, name, type, tags)
        {
            SqlDatabaseId = sqlDatabaseId;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            this._colls = _colls;
            this._users = _users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL database
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string SqlDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties._rid")]
        public string _rid { get; set; }

        /// <summary>
        /// Gets or sets a system generated property that denotes the last
        /// updated timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties._ts")]
        public object _ts { get; set; }

        /// <summary>
        /// Gets or sets a system generated property representing the resource
        /// etag required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "properties._etag")]
        public string _etag { get; set; }

        /// <summary>
        /// Gets or sets a system generated property that specified the
        /// addressable path of the collections resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties._colls")]
        public string _colls { get; set; }

        /// <summary>
        /// Gets or sets a system generated property that specifies the
        /// addressable path of the users resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties._users")]
        public string _users { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SqlDatabaseId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SqlDatabaseId");
            }
        }
    }
}
