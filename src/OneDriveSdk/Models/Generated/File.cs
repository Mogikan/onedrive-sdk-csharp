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
    using System.Text.Json.Serialization;
    using Microsoft.Graph;

    /// <summary>
    /// The type File.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter<File>))]
    public partial class File
    {
    
        /// <summary>
        /// Gets or sets hashes.
        /// </summary>
        [JsonPropertyName("hashes")]
        public Hashes Hashes { get; set; }
    
        /// <summary>
        /// Gets or sets mimeType.
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
