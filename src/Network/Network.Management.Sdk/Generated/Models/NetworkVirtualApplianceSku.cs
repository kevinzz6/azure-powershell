// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Definition of the NetworkVirtualApplianceSkus resource.
    /// </summary>
    /// <remarks>
    /// Definition of the NetworkVirtualApplianceSkus resource.
    /// </remarks>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class NetworkVirtualApplianceSku : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkVirtualApplianceSku class.
        /// </summary>
        public NetworkVirtualApplianceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkVirtualApplianceSku class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="vendor">Network Virtual Appliance Sku vendor.
        /// </param>

        /// <param name="availableVersions">Available Network Virtual Appliance versions.
        /// </param>

        /// <param name="availableScaleUnits">The list of scale units available.
        /// </param>
        public NetworkVirtualApplianceSku(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string vendor = default(string), System.Collections.Generic.IList<string> availableVersions = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<NetworkVirtualApplianceSkuInstances> availableScaleUnits = default(System.Collections.Generic.IList<NetworkVirtualApplianceSkuInstances>))

        : base(id, name, type, location, tags)
        {
            this.Etag = etag;
            this.Vendor = vendor;
            this.AvailableVersions = availableVersions;
            this.AvailableScaleUnits = availableScaleUnits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets network Virtual Appliance Sku vendor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vendor")]
        public string Vendor {get; private set; }

        /// <summary>
        /// Gets available Network Virtual Appliance versions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.availableVersions")]
        public System.Collections.Generic.IList<string> AvailableVersions {get; private set; }

        /// <summary>
        /// Gets or sets the list of scale units available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.availableScaleUnits")]
        public System.Collections.Generic.IList<NetworkVirtualApplianceSkuInstances> AvailableScaleUnits {get; set; }
    }
}