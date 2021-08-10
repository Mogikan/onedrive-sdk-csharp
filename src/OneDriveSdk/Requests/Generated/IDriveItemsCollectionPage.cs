// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using Microsoft.Graph;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IDriveItemsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<DriveItemsCollectionPage>))]
    public interface IDriveItemsCollectionPage : ICollectionPage<Item>
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveItemsCollectionRequest"/> instance.
        /// </summary>
        IDriveItemsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
