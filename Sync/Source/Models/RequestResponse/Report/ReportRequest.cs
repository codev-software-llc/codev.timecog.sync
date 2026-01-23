//-----------------------------------------------------------------------------
// <copyright file="ReportRequest.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Model;
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the means to invoke a request for a report.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ReportRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportRequest()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 ReportId { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the client filter.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 ClientId { get; set; }

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

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set time interval (granularity) of the report.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportInterval ReportInterval { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the size of the report.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportSize ReportSize { get; set; }
        #endregion
    }
}