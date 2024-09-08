//-----------------------------------------------------------------------------
// <copyright file="DestinationData.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides destination information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationData()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the address (phone number or email).
        /// </summary>
        ///--------------------------------------------------------------------
        public String Address { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set type type of destination.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationType DestinationType { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether it's a primary destination.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsPrimary { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the destination is confirmed.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsConfirmed { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the item can be edited.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanEdit { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the item can be deleted.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanDelete { get; set; }
        #endregion
    }
}
