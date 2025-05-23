// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Describes a license in a hybrid machine.</summary>
    public partial class License :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicense,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGenerated __trackedResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.TrackedResourceAutoGenerated();

        /// <summary>Describes the number of assigned licenses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public int? DetailAssignedLicense { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailAssignedLicense; }

        /// <summary>
        /// Describes the edition of the license. The values are either Standard or Datacenter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string DetailEdition { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailEdition; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailEdition = value ?? null; }

        /// <summary>Describes the immutable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string DetailImmutableId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailImmutableId; }

        /// <summary>Describes the number of processors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public int? DetailProcessor { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailProcessor; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailProcessor = value ?? default(int); }

        /// <summary>Describes the state of the license.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string DetailState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailState = value ?? null; }

        /// <summary>Describes the license target server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string DetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailTarget = value ?? null; }

        /// <summary>Describes the license core type (pCore or vCore).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string DetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailType = value ?? null; }

        /// <summary>A list of volume license details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVolumeLicenseDetails> DetailVolumeLicenseDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailVolumeLicenseDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailVolumeLicenseDetail = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Id; }

        /// <summary>The type of the license resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string LicenseType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseType = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Location = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseDetails Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetail = value; }

        /// <summary>Internal Acessors for DetailAssignedLicense</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseInternal.DetailAssignedLicense { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailAssignedLicense; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailAssignedLicense = value; }

        /// <summary>Internal Acessors for DetailImmutableId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseInternal.DetailImmutableId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailImmutableId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).LicenseDetailImmutableId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseProperties Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LicenseProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseProperties _property;

        /// <summary>Hybrid Compute License properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LicenseProperties()); set => this._property = value; }

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Tag = value ?? null /* model class */; }

        /// <summary>Describes the tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicensePropertiesInternal)Property).TenantId = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceAutoGeneratedInternal)__trackedResourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="License" /> instance.</summary>
        public License()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResourceAutoGenerated), __trackedResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__trackedResourceAutoGenerated), __trackedResourceAutoGenerated);
        }
    }
    /// Describes a license in a hybrid machine.
    public partial interface ILicense :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGenerated
    {
        /// <summary>Describes the number of assigned licenses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Describes the number of assigned licenses.",
        SerializedName = @"assignedLicenses",
        PossibleTypes = new [] { typeof(int) })]
        int? DetailAssignedLicense { get;  }
        /// <summary>
        /// Describes the edition of the license. The values are either Standard or Datacenter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the edition of the license. The values are either Standard or Datacenter.",
        SerializedName = @"edition",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Standard", "Datacenter")]
        string DetailEdition { get; set; }
        /// <summary>Describes the immutable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Describes the immutable id.",
        SerializedName = @"immutableId",
        PossibleTypes = new [] { typeof(string) })]
        string DetailImmutableId { get;  }
        /// <summary>Describes the number of processors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the number of processors.",
        SerializedName = @"processors",
        PossibleTypes = new [] { typeof(int) })]
        int? DetailProcessor { get; set; }
        /// <summary>Describes the state of the license.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the state of the license.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Activated", "Deactivated")]
        string DetailState { get; set; }
        /// <summary>Describes the license target server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the license target server.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Windows Server 2012", "Windows Server 2012 R2")]
        string DetailTarget { get; set; }
        /// <summary>Describes the license core type (pCore or vCore).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the license core type (pCore or vCore).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("pCore", "vCore")]
        string DetailType { get; set; }
        /// <summary>A list of volume license details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of volume license details.",
        SerializedName = @"volumeLicenseDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVolumeLicenseDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVolumeLicenseDetails> DetailVolumeLicenseDetail { get; set; }
        /// <summary>The type of the license resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the license resource.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("ESU")]
        string LicenseType { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get; set; }
        /// <summary>Describes the tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// Describes a license in a hybrid machine.
    internal partial interface ILicenseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceAutoGeneratedInternal
    {
        /// <summary>Describes the properties of a License.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseDetails Detail { get; set; }
        /// <summary>Describes the number of assigned licenses.</summary>
        int? DetailAssignedLicense { get; set; }
        /// <summary>
        /// Describes the edition of the license. The values are either Standard or Datacenter.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Standard", "Datacenter")]
        string DetailEdition { get; set; }
        /// <summary>Describes the immutable id.</summary>
        string DetailImmutableId { get; set; }
        /// <summary>Describes the number of processors.</summary>
        int? DetailProcessor { get; set; }
        /// <summary>Describes the state of the license.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Activated", "Deactivated")]
        string DetailState { get; set; }
        /// <summary>Describes the license target server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Windows Server 2012", "Windows Server 2012 R2")]
        string DetailTarget { get; set; }
        /// <summary>Describes the license core type (pCore or vCore).</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("pCore", "vCore")]
        string DetailType { get; set; }
        /// <summary>A list of volume license details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVolumeLicenseDetails> DetailVolumeLicenseDetail { get; set; }
        /// <summary>The type of the license resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("ESU")]
        string LicenseType { get; set; }
        /// <summary>Hybrid Compute License properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILicenseProperties Property { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get; set; }
        /// <summary>Describes the tenant id.</summary>
        string TenantId { get; set; }

    }
}