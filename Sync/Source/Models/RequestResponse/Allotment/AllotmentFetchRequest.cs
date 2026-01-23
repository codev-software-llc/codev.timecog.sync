//-----------------------------------------------------------------------------
// <copyright file="AllotmentFetchRequest.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the means to invoke a request for a range of allotments.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AllotmentFetchRequest
    {
        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the task identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the start date.
        /// </summary>
        ///--------------------------------------------------------------------
        public LocalDate DateStart { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the end date.
        /// </summary>
        ///--------------------------------------------------------------------
        public LocalDate DateEnd { get; set; }
        #endregion
    }
}