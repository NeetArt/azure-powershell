// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The effective network security group association.
    /// </summary>
    public partial class EffectiveNetworkSecurityGroupAssociation
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>
        public EffectiveNetworkSecurityGroupAssociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroupAssociation class.
        /// </summary>

        /// <param name="networkManager">The ID of the Azure network manager if assigned.
        /// </param>

        /// <param name="subnet">The ID of the subnet if assigned.
        /// </param>

        /// <param name="networkInterface">The ID of the network interface if assigned.
        /// </param>
        public EffectiveNetworkSecurityGroupAssociation(SubResource networkManager = default(SubResource), SubResource subnet = default(SubResource), SubResource networkInterface = default(SubResource))

        {
            this.NetworkManager = networkManager;
            this.Subnet = subnet;
            this.NetworkInterface = networkInterface;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the ID of the Azure network manager if assigned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkManager")]
        public SubResource NetworkManager {get; set; }

        /// <summary>
        /// Gets or sets the ID of the subnet if assigned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subnet")]
        public SubResource Subnet {get; set; }

        /// <summary>
        /// Gets or sets the ID of the network interface if assigned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkInterface")]
        public SubResource NetworkInterface {get; set; }
    }
}