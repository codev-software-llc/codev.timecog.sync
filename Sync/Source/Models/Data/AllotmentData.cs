//-----------------------------------------------------------------------------
// <copyright file="AllotmentData.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides time allotment detailed data.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AllotmentData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AllotmentData()
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
        /// Get or set the date of the allotment.
        /// </summary>
        ///--------------------------------------------------------------------
        public LocalDate Date { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the duration.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration Duration { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we're allowed to edit the item.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanEdit { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we're allowed to delete the item.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanDelete { get; set; }
        #endregion
    }
}
