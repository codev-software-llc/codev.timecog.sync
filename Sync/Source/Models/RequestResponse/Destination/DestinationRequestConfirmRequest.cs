//-----------------------------------------------------------------------------
// <copyright file="DestinationRequestConfirmRequest.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to request a confirmation be sent.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationRequestConfirmRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationRequestConfirmRequest()
        {
            this.Destination = new DestinationApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationApiModel Destination { get; set; }
        #endregion
    }
}