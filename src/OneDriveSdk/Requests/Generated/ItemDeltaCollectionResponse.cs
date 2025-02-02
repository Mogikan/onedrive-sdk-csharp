// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Graph;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ItemDeltaCollectionResponse.
    /// </summary>
    [DataContract]
    public class ItemDeltaCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IItemDeltaCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public IItemDeltaCollectionPage Value { get; set; }
        
        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        [DataMember(Name = "@delta.token", EmitDefaultValue = false, IsRequired = false)]
        public string Token { get; set; }
        
        /// <summary>
        /// Gets or sets the DeltaLink.
        /// </summary>
        [DataMember(Name = "@delta.deltaLink", EmitDefaultValue = false, IsRequired = false)]
        public string DeltaLink { get; set; }
        
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
