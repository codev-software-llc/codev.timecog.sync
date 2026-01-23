//-----------------------------------------------------------------------------
// <copyright file="DestinationConfirmRequest.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to send the confirmation code and retrieve
    /// the secret-key.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationConfirmRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationConfirmRequest()
        {
            this.Destination      = new DestinationApiModel();
            this.ConfirmationCode = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationApiModel Destination { get; set; }

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