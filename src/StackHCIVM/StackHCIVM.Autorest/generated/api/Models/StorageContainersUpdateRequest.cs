// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>The storage container resource patch definition.</summary>
    public partial class StorageContainersUpdateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequest,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.StorageContainersUpdateRequestTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="StorageContainersUpdateRequest" /> instance.</summary>
        public StorageContainersUpdateRequest()
        {

        }
    }
    /// The storage container resource patch definition.
    public partial interface IStorageContainersUpdateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestTags Tag { get; set; }

    }
    /// The storage container resource patch definition.
    internal partial interface IStorageContainersUpdateRequestInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IStorageContainersUpdateRequestTags Tag { get; set; }

    }
}