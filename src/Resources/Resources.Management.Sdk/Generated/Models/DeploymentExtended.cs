// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment information.
    /// </summary>
    public partial class DeploymentExtended : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        public DeploymentExtended()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>

        /// <param name="id">The ID of the deployment.
        /// </param>

        /// <param name="name">The name of the deployment.
        /// </param>

        /// <param name="type">The type of the deployment.
        /// </param>

        /// <param name="location">the location of the deployment.
        /// </param>

        /// <param name="properties">Deployment properties.
        /// </param>

        /// <param name="tags">Deployment tags
        /// </param>
        public DeploymentExtended(string id = default(string), string name = default(string), string type = default(string), string location = default(string), DeploymentPropertiesExtended properties = default(DeploymentPropertiesExtended), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Location = location;
            this.Properties = properties;
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the ID of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets the name of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets the type of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets the location of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public DeploymentPropertiesExtended Properties {get; set; }

        /// <summary>
        /// Gets or sets deployment tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {




            if (this.Properties != null)
            {
                this.Properties.Validate();
            }

        }
    }
}