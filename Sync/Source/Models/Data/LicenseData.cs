//-----------------------------------------------------------------------------
// <copyright file="LicenseData.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using System;
    using System.Collections.Generic;
    using Codev.Core.Common.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides license information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class LicenseData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public LicenseData()
        {
            this.Features = new List<LicenseFeatureData>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the license identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the name of the license.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the cost of the license.
        /// </summary>
        ///--------------------------------------------------------------------
        public PaymentAmount Cost { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the feature list.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<LicenseFeatureData> Features { get; set; }
        #endregion
    }
}
