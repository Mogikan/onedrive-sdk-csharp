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
    /// The type Photo.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter<Photo>))]
    public partial class Photo
    {
    
        /// <summary>
        /// Gets or sets cameraMake.
        /// </summary>
        [JsonPropertyName("cameraMake")]
        public string CameraMake { get; set; }
    
        /// <summary>
        /// Gets or sets cameraModel.
        /// </summary>
        [JsonPropertyName("cameraModel")]
        public string CameraModel { get; set; }
    
        /// <summary>
        /// Gets or sets exposureDenominator.
        /// </summary>
        [JsonPropertyName("exposureDenominator")]
        public double? ExposureDenominator { get; set; }
    
        /// <summary>
        /// Gets or sets exposureNumerator.
        /// </summary>
        [JsonPropertyName("exposureNumerator")]
        public double? ExposureNumerator { get; set; }
    
        /// <summary>
        /// Gets or sets focalLength.
        /// </summary>
        [JsonPropertyName("focalLength")]
        public double? FocalLength { get; set; }
    
        /// <summary>
        /// Gets or sets fNumber.
        /// </summary>
        [JsonPropertyName("fNumber")]
        public double? FNumber { get; set; }
    
        /// <summary>
        /// Gets or sets takenDateTime.
        /// </summary>
        [JsonPropertyName("takenDateTime")]
        public DateTimeOffset? TakenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets iso.
        /// </summary>
        [JsonPropertyName("iso")]
        public Int32? Iso { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
