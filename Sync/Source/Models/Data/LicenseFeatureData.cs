//-----------------------------------------------------------------------------
// <copyright file="LicenseFeatureData.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides license feature information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class LicenseFeatureData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public LicenseFeatureData()
        {
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
        /// Get or set the feature name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the feature is enabled.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsEnabled { get; set; }
        #endregion
    }
}
