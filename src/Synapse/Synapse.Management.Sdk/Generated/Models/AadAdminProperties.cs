// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Workspace active directory administrator properties
    /// </summary>
    public partial class AadAdminProperties
    {
        /// <summary>
        /// Initializes a new instance of the AadAdminProperties class.
        /// </summary>
        public AadAdminProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AadAdminProperties class.
        /// </summary>

        /// <param name="tenantId">Tenant ID of the workspace active directory administrator
        /// </param>

        /// <param name="login">Login of the workspace active directory administrator
        /// </param>

        /// <param name="administratorType">Workspace active directory administrator type
        /// </param>

        /// <param name="sid">Object ID of the workspace active directory administrator
        /// </param>
        public AadAdminProperties(string tenantId = default(string), string login = default(string), string administratorType = default(string), string sid = default(string))

        {
            this.TenantId = tenantId;
            this.Login = login;
            this.AdministratorType = administratorType;
            this.Sid = sid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets tenant ID of the workspace active directory administrator
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public string TenantId {get; set; }

        /// <summary>
        /// Gets or sets login of the workspace active directory administrator
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "login")]
        public string Login {get; set; }

        /// <summary>
        /// Gets or sets workspace active directory administrator type
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "administratorType")]
        public string AdministratorType {get; set; }

        /// <summary>
        /// Gets or sets object ID of the workspace active directory administrator
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sid")]
        public string Sid {get; set; }
    }
}