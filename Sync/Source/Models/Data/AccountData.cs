//-----------------------------------------------------------------------------
// <copyright file="AccountData.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using System.Collections.Generic;
    using Codev.Core.Common.Model;
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides account information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AccountData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountData()
        {
            this.Name           = String.Empty;
            this.CompanyName    = String.Empty;
            this.ReportInterval = ReportInterval.FifteenMinutes;
            this.TimeZone       = DateTimeZone.Utc;
            this.License        = new LicenseData();
            this.Reports        = new List<ReportData>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the identifier of the account as it lives on the server.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the account name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the company name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String CompanyName { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report interval.
        /// </summary>
        ///--------------------------------------------------------------------
        public ReportInterval ReportInterval { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the time zone identifier (String).
        /// </summary>
        ///--------------------------------------------------------------------
        public DateTimeZone TimeZone { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the license detail.
        /// </summary>
        ///--------------------------------------------------------------------
        public LicenseData License { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the report definitions.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<ReportData> Reports { get; set; }
        #endregion
    }
}
