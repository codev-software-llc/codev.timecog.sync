//-----------------------------------------------------------------------------
// <copyright file="ReportData.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides the report information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ReportData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the service.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportData()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the title of the report.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Title { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report description.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Description { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether a date range is required.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsRangeRequired { get; set; }
        #endregion
    }
}
