//-----------------------------------------------------------------------------
// <copyright file="ReportResponse.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using Codev.Core.Common.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response from a report request.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ReportResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the response.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportResponse()
        {
            this.ReportContent = new ReportContent();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report content.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportContent ReportContent { get; set; }
        #endregion
    }
}