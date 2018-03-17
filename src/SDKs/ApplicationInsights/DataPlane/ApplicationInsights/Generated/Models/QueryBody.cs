// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query request body
    /// </summary>
    public partial class QueryBody
    {
        /// <summary>
        /// Initializes a new instance of the QueryBody class.
        /// </summary>
        public QueryBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryBody class.
        /// </summary>
        /// <param name="query">The query to execute.</param>
        /// <param name="timespan">Optional. The timespan over which to query
        /// data. This is an ISO8601 time period value.  This timespan is
        /// applied in addition to any that are specified in the query
        /// expression.</param>
        /// <param name="applications">A list of applications that are included
        /// in the query.</param>
        public QueryBody(string query, System.TimeSpan? timespan = default(System.TimeSpan?), IList<string> applications = default(IList<string>))
        {
            Query = query;
            Timespan = timespan;
            Applications = applications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query to execute.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets optional. The timespan over which to query data. This
        /// is an ISO8601 time period value.  This timespan is applied in
        /// addition to any that are specified in the query expression.
        /// </summary>
        [JsonProperty(PropertyName = "timespan")]
        public System.TimeSpan? Timespan { get; set; }

        /// <summary>
        /// Gets or sets a list of applications that are included in the query.
        /// </summary>
        [JsonProperty(PropertyName = "applications")]
        public IList<string> Applications { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
        }
    }
}