//-----------------------------------------------------------------------------
// <copyright file="AuthenticateResponse.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response to the AuthenticateRequest call.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AuthenticateResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the response.
        /// </summary>
        ///--------------------------------------------------------------------
        public AuthenticateResponse()
        {
            this.Destination = new DestinationApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the the destination address.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationApiModel Destination { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the date/time when the confirmation code will expire.
        /// This is in UTC format.
        /// </summary>
        ///--------------------------------------------------------------------
        public Duration ConfirmationCodeExpiration { get; set; }
        #endregion
    }
}