//-----------------------------------------------------------------------------
// <copyright file="DestinationSetPrimaryRequest.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to set a destination as primary.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationSetPrimaryRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationSetPrimaryRequest()
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