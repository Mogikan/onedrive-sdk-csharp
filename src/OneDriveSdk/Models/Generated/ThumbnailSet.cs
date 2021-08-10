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
    /// The type Thumbnail Set.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter<ThumbnailSet>))]
    public partial class ThumbnailSet
    {
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets large.
        /// </summary>
        [JsonPropertyName("large")]
        public Thumbnail Large { get; set; }
    
        /// <summary>
        /// Gets or sets medium.
        /// </summary>
        [JsonPropertyName("medium")]
        public Thumbnail Medium { get; set; }
    
        /// <summary>
        /// Gets or sets small.
        /// </summary>
        [JsonPropertyName("small")]
        public Thumbnail Small { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [JsonPropertyName("source")]
        public Thumbnail Source { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [DataMember(Name = "@odata.type", EmitDefaultValue = false, IsRequired = false)]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

