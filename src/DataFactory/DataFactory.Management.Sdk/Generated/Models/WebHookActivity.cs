// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// WebHook activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebHook")]
    [Rest.Serialization.JsonTransformation]
    public partial class WebHookActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the WebHookActivity class.
        /// </summary>
        public WebHookActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebHookActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="url">WebHook activity target endpoint and path. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="state">Activity state. This is an optional property
        /// and if not provided, the state will be Active by default. Possible
        /// values include: 'Active', 'Inactive'</param>
        /// <param name="onInactiveMarkAs">Status result of the activity when
        /// the state is set to Inactive. This is an optional property and if
        /// not provided when the activity is inactive, the status will be
        /// Succeeded by default. Possible values include: 'Succeeded',
        /// 'Failed', 'Skipped'</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="timeout">The timeout within which the webhook should
        /// be called back. If there is no value specified, it defaults to 10
        /// minutes. Type: string. Pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="headers">Represents the headers that will be sent to
        /// the request. For example, to set the language and type on a
        /// request: "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="body">Represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="authentication">Authentication method used for calling
        /// the endpoint.</param>
        /// <param name="reportStatusOnCallBack">When set to true, statusCode,
        /// output and error in callback request body will be consumed by
        /// activity. The activity can be marked as failed by setting
        /// statusCode &gt;= 400 in callback request. Default is false. Type:
        /// boolean (or Expression with resultType boolean).</param>
        /// <param name="policy">Activity policy.</param>
        public WebHookActivity(string name, object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), string timeout = default(string), object headers = default(object), object body = default(object), WebActivityAuthentication authentication = default(WebActivityAuthentication), object reportStatusOnCallBack = default(object), SecureInputOutputPolicy policy = default(SecureInputOutputPolicy))
            : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties)
        {
            Url = url;
            Timeout = timeout;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            ReportStatusOnCallBack = reportStatusOnCallBack;
            Policy = policy;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for WebHookActivity class.
        /// </summary>
        static WebHookActivity()
        {
            Method = "POST";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets webHook activity target endpoint and path. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the timeout within which the webhook should be called
        /// back. If there is no value specified, it defaults to 10 minutes.
        /// Type: string. Pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or sets represents the headers that will be sent to the
        /// request. For example, to set the language and type on a request:
        /// "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headers")]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.body")]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets authentication method used for calling the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authentication")]
        public WebActivityAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or sets when set to true, statusCode, output and error in
        /// callback request body will be consumed by activity. The activity
        /// can be marked as failed by setting statusCode &amp;gt;= 400 in
        /// callback request. Default is false. Type: boolean (or Expression
        /// with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.reportStatusOnCallBack")]
        public object ReportStatusOnCallBack { get; set; }

        /// <summary>
        /// Gets or sets activity policy.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public SecureInputOutputPolicy Policy { get; set; }

        /// <summary>
        /// Rest API method for target endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public static string Method { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Authentication != null)
            {
                Authentication.Validate();
            }
        }
    }
}
