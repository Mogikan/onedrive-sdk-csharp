// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Microsoft.Graph;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SharingLink.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter<SharingLink>))]
    public partial class SharingLink
    {
    
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [JsonPropertyName("application")]
        public Identity Application { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets webUrl.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets webHtml.
        /// </summary>
        [JsonPropertyName("webHtml")]
        public string WebHtml { get; set; }
    
        /// <summary>
        /// Gets or sets configuratorUrl.
        /// </summary>
        [JsonPropertyName("configuratorUrl")]
        public string ConfiguratorUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
