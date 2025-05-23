// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The retry history.
    /// </summary>
    public partial class RetryHistory
    {
        /// <summary>
        /// Initializes a new instance of the RetryHistory class.
        /// </summary>
        public RetryHistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetryHistory class.
        /// </summary>

        /// <param name="startTime">Gets the start time.
        /// </param>

        /// <param name="endTime">Gets the end time.
        /// </param>

        /// <param name="code">Gets the status code.
        /// </param>

        /// <param name="clientRequestId">Gets the client request Id.
        /// </param>

        /// <param name="serviceRequestId">Gets the service request Id.
        /// </param>

        /// <param name="error">Gets the error response.
        /// </param>
        public RetryHistory(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string code = default(string), string clientRequestId = default(string), string serviceRequestId = default(string), ErrorResponse error = default(ErrorResponse))

        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Code = code;
            this.ClientRequestId = clientRequestId;
            this.ServiceRequestId = serviceRequestId;
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets the start time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; set; }

        /// <summary>
        /// Gets or sets gets the end time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime {get; set; }

        /// <summary>
        /// Gets or sets gets the status code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code {get; set; }

        /// <summary>
        /// Gets or sets gets the client request Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clientRequestId")]
        public string ClientRequestId {get; set; }

        /// <summary>
        /// Gets or sets gets the service request Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceRequestId")]
        public string ServiceRequestId {get; set; }

        /// <summary>
        /// Gets or sets gets the error response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public ErrorResponse Error {get; set; }
    }
}