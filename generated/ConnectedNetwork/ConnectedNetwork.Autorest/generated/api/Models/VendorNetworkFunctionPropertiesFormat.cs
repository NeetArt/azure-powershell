// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Vendor network function properties.</summary>
    public partial class VendorNetworkFunctionPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IVendorNetworkFunctionPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IVendorNetworkFunctionPropertiesFormatInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IVendorNetworkFunctionPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for SkuName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IVendorNetworkFunctionPropertiesFormatInternal.SkuName { get => this._skuName; set { {_skuName = value;} } }

        /// <summary>Backing field for <see cref="NetworkFunctionVendorConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionVendorConfiguration> _networkFunctionVendorConfiguration;

        /// <summary>An array of network function vendor configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionVendorConfiguration> NetworkFunctionVendorConfiguration { get => this._networkFunctionVendorConfiguration; set => this._networkFunctionVendorConfiguration = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the vendor network function sub resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SkuName" /> property.</summary>
        private string _skuName;

        /// <summary>The name of the sku. Once set, it cannot be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string SkuName { get => this._skuName; }

        /// <summary>Backing field for <see cref="SkuType" /> property.</summary>
        private string _skuType;

        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string SkuType { get => this._skuType; set => this._skuType = value; }

        /// <summary>Backing field for <see cref="VendorProvisioningState" /> property.</summary>
        private string _vendorProvisioningState;

        /// <summary>The vendor controlled provisioning state of the vendor network function.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string VendorProvisioningState { get => this._vendorProvisioningState; set => this._vendorProvisioningState = value; }

        /// <summary>Creates an new <see cref="VendorNetworkFunctionPropertiesFormat" /> instance.</summary>
        public VendorNetworkFunctionPropertiesFormat()
        {

        }
    }
    /// Vendor network function properties.
    public partial interface IVendorNetworkFunctionPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>An array of network function vendor configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of network function vendor configurations.",
        SerializedName = @"networkFunctionVendorConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionVendorConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionVendorConfiguration> NetworkFunctionVendorConfiguration { get; set; }
        /// <summary>The provisioning state of the vendor network function sub resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the vendor network function sub resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>The name of the sku. Once set, it cannot be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the sku. Once set, it cannot be updated.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get;  }
        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku type.",
        SerializedName = @"skuType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "EvolvedPacketCore", "SDWAN", "Firewall")]
        string SkuType { get; set; }
        /// <summary>The vendor controlled provisioning state of the vendor network function.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The vendor controlled provisioning state of the vendor network function.",
        SerializedName = @"vendorProvisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "NotProvisioned", "Provisioning", "Provisioned", "Deprovisioned", "UserDataValidationFailed")]
        string VendorProvisioningState { get; set; }

    }
    /// Vendor network function properties.
    internal partial interface IVendorNetworkFunctionPropertiesFormatInternal

    {
        /// <summary>An array of network function vendor configurations.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkFunctionVendorConfiguration> NetworkFunctionVendorConfiguration { get; set; }
        /// <summary>The provisioning state of the vendor network function sub resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>The name of the sku. Once set, it cannot be updated.</summary>
        string SkuName { get; set; }
        /// <summary>The sku type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "EvolvedPacketCore", "SDWAN", "Firewall")]
        string SkuType { get; set; }
        /// <summary>The vendor controlled provisioning state of the vendor network function.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PSArgumentCompleterAttribute("Unknown", "NotProvisioned", "Provisioning", "Provisioned", "Deprovisioned", "UserDataValidationFailed")]
        string VendorProvisioningState { get; set; }

    }
}