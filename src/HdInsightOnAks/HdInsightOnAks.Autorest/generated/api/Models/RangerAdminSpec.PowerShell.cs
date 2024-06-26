// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.PowerShell;

    /// <summary>Specification for the Ranger Admin service.</summary>
    [System.ComponentModel.TypeConverter(typeof(RangerAdminSpecTypeConverter))]
    public partial class RangerAdminSpec
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpec"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpec" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpec DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RangerAdminSpec(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpec"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpec" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpec DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RangerAdminSpec(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RangerAdminSpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RangerAdminSpec" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpec FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpec"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RangerAdminSpec(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Database"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Database = (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecDatabase) content.GetValueForProperty("Database",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Database, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpecDatabaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("Admin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Admin = (System.Collections.Generic.List<string>) content.GetValueForProperty("Admin",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Admin, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseHost = (string) content.GetValueForProperty("DatabaseHost",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseHost, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabasePasswordSecretRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabasePasswordSecretRef = (string) content.GetValueForProperty("DatabasePasswordSecretRef",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabasePasswordSecretRef, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseUsername = (string) content.GetValueForProperty("DatabaseUsername",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseUsername, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpec"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RangerAdminSpec(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Database"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Database = (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecDatabase) content.GetValueForProperty("Database",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Database, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.RangerAdminSpecDatabaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("Admin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Admin = (System.Collections.Generic.List<string>) content.GetValueForProperty("Admin",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).Admin, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseHost = (string) content.GetValueForProperty("DatabaseHost",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseHost, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabasePasswordSecretRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabasePasswordSecretRef = (string) content.GetValueForProperty("DatabasePasswordSecretRef",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabasePasswordSecretRef, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseUsername = (string) content.GetValueForProperty("DatabaseUsername",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IRangerAdminSpecInternal)this).DatabaseUsername, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Specification for the Ranger Admin service.
    [System.ComponentModel.TypeConverter(typeof(RangerAdminSpecTypeConverter))]
    public partial interface IRangerAdminSpec

    {

    }
}