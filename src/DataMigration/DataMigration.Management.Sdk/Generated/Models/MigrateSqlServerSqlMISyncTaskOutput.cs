// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Output for task that migrates SQL Server databases to Azure SQL Database
    /// Managed Instance using Log Replay Service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MigrateSqlServerSqlMiSyncTaskOutput")]
    public partial class MigrateSqlServerSqlMISyncTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the MigrateSqlServerSqlMISyncTaskOutput class.
        /// </summary>
        public MigrateSqlServerSqlMISyncTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateSqlServerSqlMISyncTaskOutput class.
        /// </summary>

        /// <param name="id">Result identifier
        /// </param>
        public MigrateSqlServerSqlMISyncTaskOutput(string id = default(string))

        {
            this.Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets result identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }
    }
}