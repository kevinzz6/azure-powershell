// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Service Community Properties.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class BgpServiceCommunity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BgpServiceCommunity class.
        /// </summary>
        public BgpServiceCommunity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BgpServiceCommunity class.
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

        /// <param name="serviceName">The name of the bgp community. e.g. Skype.
        /// </param>

        /// <param name="bgpCommunities">A list of bgp communities.
        /// </param>
        public BgpServiceCommunity(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string serviceName = default(string), System.Collections.Generic.IList<BGPCommunity> bgpCommunities = default(System.Collections.Generic.IList<BGPCommunity>))

        : base(id, name, type, location, tags)
        {
            this.ServiceName = serviceName;
            this.BgpCommunities = bgpCommunities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the bgp community. e.g. Skype.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceName")]
        public string ServiceName {get; set; }

        /// <summary>
        /// Gets or sets a list of bgp communities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.bgpCommunities")]
        public System.Collections.Generic.IList<BGPCommunity> BgpCommunities {get; set; }
    }
}