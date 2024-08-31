//-----------------------------------------------------------------------------
// <copyright file="SynchronizeResponse.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using Codev.Core.Common.Base;
    using Codev.Core.Common.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the means to invoke a server connection.
    /// </summary>
    ///------------------------------------------------------------------------
    public class SynchronizeResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the service.
        /// </summary>
        ///--------------------------------------------------------------------
        public SynchronizeResponse()
        {
            this.VersionInfo = new VersionInfo();
            this.Account     = new AccountApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the current version of the application.  We could use
        /// this to check for updates.
        /// </summary>
        ///--------------------------------------------------------------------
        public VersionInfo VersionInfo { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the account object.  This contains the hierarchy of all
        /// the clients, projects, assignments and such.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountApiModel Account { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the account summary report.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountSummaryReport AccountSummary { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the monthly report for projects.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportContent MonthlyProjectReport { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the weekliy report for projects.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportContent WeeklyProjectReport { get; set; }
        #endregion
    }
}