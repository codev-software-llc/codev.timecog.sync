//-----------------------------------------------------------------------------
// <copyright file="DestinationCreateRequest.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the request object to create a new destination.
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationCreateRequest
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationCreateRequest()
        {
            this.Address = String.Empty;
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination address.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationType DestinationType { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the destination address.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Address { get; set; }
        #endregion
    }
}