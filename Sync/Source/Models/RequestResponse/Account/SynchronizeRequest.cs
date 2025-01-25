//-----------------------------------------------------------------------------
// <copyright file="SynchronizeRequest.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using Codev.Core.Base;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the structure to use in a WebApi call to update the server with
    /// information collected.
    /// </summary>
    ///------------------------------------------------------------------------
    public class SynchronizeRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public SynchronizeRequest()
        {
            this.VersionInfo   = new VersionInfo();
            this.Account       = new AccountApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the version information of the application.
        /// </summary>
        ///--------------------------------------------------------------------
        public VersionInfo VersionInfo { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the account object.  This contains the information to
        /// update to the server.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountApiModel Account { get; set; }
        #endregion
    }
}