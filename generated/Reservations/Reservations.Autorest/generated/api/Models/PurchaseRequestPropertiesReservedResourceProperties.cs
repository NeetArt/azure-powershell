// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>
    /// Properties specific to each reserved resource type. Not required if not applicable.
    /// </summary>
    public partial class PurchaseRequestPropertiesReservedResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPurchaseRequestPropertiesReservedResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPurchaseRequestPropertiesReservedResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceFlexibility" /> property.</summary>
        private string _instanceFlexibility;

        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string InstanceFlexibility { get => this._instanceFlexibility; set => this._instanceFlexibility = value; }

        /// <summary>
        /// Creates an new <see cref="PurchaseRequestPropertiesReservedResourceProperties" /> instance.
        /// </summary>
        public PurchaseRequestPropertiesReservedResourceProperties()
        {

        }
    }
    /// Properties specific to each reserved resource type. Not required if not applicable.
    public partial interface IPurchaseRequestPropertiesReservedResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type.",
        SerializedName = @"instanceFlexibility",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("On", "Off")]
        string InstanceFlexibility { get; set; }

    }
    /// Properties specific to each reserved resource type. Not required if not applicable.
    internal partial interface IPurchaseRequestPropertiesReservedResourcePropertiesInternal

    {
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("On", "Off")]
        string InstanceFlexibility { get; set; }

    }
}