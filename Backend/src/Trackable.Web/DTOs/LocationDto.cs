// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Trackable.Models;

namespace Trackable.Web.Dtos
{
    public class LocationDto
    {
        /// <summary>
        /// Autogenerated location id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Location Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Location Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Location Latitude
        /// </summary>
        [Required]
        public double Latitude { get; set; }
        
        /// <summary>
        /// Location Longitude
        /// </summary>
        [Required]
        public double Longitude { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<string> Tags { get; set; }
    }
}
