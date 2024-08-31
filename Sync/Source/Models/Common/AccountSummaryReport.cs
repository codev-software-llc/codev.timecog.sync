//-----------------------------------------------------------------------------
// <copyright file="AccountSummaryReport.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for a column in a report.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AccountSummaryReport
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountSummaryReport()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the time logged for the month.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration TotalMonth { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the time logged for the week.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration TotalWeek { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the time logged for the day.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration TotalDay { get; set; }
        #endregion
    }
}