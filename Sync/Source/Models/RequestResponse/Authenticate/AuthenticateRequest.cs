//-----------------------------------------------------------------------------
// <copyright file="AuthenticateRequest.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to begin the authentication process.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AuthenticateRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public AuthenticateRequest()
        {
            this.Address = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination type.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationType DestinationType { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination email address.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Address { get; set; }
        #endregion
    }
}