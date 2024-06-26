// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Available scope request properties</summary>
    public partial class AvailableScopeRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAvailableScopeRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAvailableScopeRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string[] _scope;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string[] Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Creates an new <see cref="AvailableScopeRequestProperties" /> instance.</summary>
        public AvailableScopeRequestProperties()
        {

        }
    }
    /// Available scope request properties
    public partial interface IAvailableScopeRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"scopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] Scope { get; set; }

    }
    /// Available scope request properties
    internal partial interface IAvailableScopeRequestPropertiesInternal

    {
        string[] Scope { get; set; }

    }
}