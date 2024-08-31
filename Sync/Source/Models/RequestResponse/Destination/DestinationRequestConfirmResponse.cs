//-----------------------------------------------------------------------------
// <copyright file="DestinationRequestConfirmResponse.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using NodaTime;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response to request for confirmation.  The code is sent
    /// to the destination.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationRequestConfirmResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the response.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationRequestConfirmResponse()
        {
            this.Destination = new DestinationApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the the destination.
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