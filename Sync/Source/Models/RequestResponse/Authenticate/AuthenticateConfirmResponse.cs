//-----------------------------------------------------------------------------
// <copyright file="AuthenticateConfirmResponse.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response to the AuthenticateConfirmRequest call.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AuthenticateConfirmResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the response.
        /// </summary>
        ///--------------------------------------------------------------------
        public AuthenticateConfirmResponse()
        {
            this.SessionSecret = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the session secret.  This secret will eventually expire,
        /// but it won't be for a significant time, or until the cliient
        /// logs off of the session.
        /// </summary>
        ///--------------------------------------------------------------------
        public String SessionSecret { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the when the session expires.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration Expiration { get; set; }
        #endregion
    }
}