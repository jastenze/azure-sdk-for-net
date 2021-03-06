// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class KeyDelivery
    {
        /// <summary>
        /// Initializes a new instance of the KeyDelivery class.
        /// </summary>
        public KeyDelivery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyDelivery class.
        /// </summary>
        /// <param name="accessControl">The access control properties for Key
        /// Delivery.</param>
        public KeyDelivery(AccessControl accessControl = default(AccessControl))
        {
            AccessControl = accessControl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access control properties for Key Delivery.
        /// </summary>
        [JsonProperty(PropertyName = "accessControl")]
        public AccessControl AccessControl { get; set; }

    }
}
