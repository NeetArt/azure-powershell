// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>List of networks.</summary>
    public partial class NetworkCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetworkCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetworkCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetwork[] _value;

        /// <summary>The Networks list details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetwork[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="NetworkCollection" /> instance.</summary>
        public NetworkCollection()
        {

        }
    }
    /// List of networks.
    public partial interface INetworkCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of next link.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The Networks list details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Networks list details.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetwork) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetwork[] Value { get; set; }

    }
    /// List of networks.
    internal partial interface INetworkCollectionInternal

    {
        /// <summary>The value of next link.</summary>
        string NextLink { get; set; }
        /// <summary>The Networks list details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.INetwork[] Value { get; set; }

    }
}