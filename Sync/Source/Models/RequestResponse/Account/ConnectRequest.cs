//-----------------------------------------------------------------------------
// <copyright file="ConnecxtRequest.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to connect to the server.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ConnectRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public ConnectRequest()
        {
            this.ApplicationId = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the application identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public String ApplicationId { get; set; }
        #endregion
    }
}