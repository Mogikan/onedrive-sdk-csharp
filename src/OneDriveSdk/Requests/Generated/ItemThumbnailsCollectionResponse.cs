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
    /// The type ItemThumbnailsCollectionResponse.
    /// </summary>
    [DataContract]
    public class ItemThumbnailsCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IItemThumbnailsCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public IItemThumbnailsCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
