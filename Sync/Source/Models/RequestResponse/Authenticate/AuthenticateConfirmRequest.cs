//-----------------------------------------------------------------------------
// <copyright file="AuthenticateRequest.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Common.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to send the confirmation code and retrieve
    /// the secret-key.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AuthenticateConfirmRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public AuthenticateConfirmRequest()
        {
            this.Address = String.Empty;
            this.ConfirmationCode   = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether this is a registration confirmation.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsRegister { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination address.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Address { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the confirmation coede that is expected during the
        /// authentication process.
        /// </summary>
        ///--------------------------------------------------------------------
        public String ConfirmationCode { get; set; }
        #endregion
    }
}