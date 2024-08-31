//-----------------------------------------------------------------------------
// <copyright file="DestinationSetPrimaryResponse.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response to setting a primary destination.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationSetPrimaryResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the response.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationSetPrimaryResponse()
        {
            this.Destination = new DestinationApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination object.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationApiModel Destination { get; set; }
        #endregion
    }
}