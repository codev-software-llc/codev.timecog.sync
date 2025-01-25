//-----------------------------------------------------------------------------
// <copyright file="ClientData.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides client information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ClientData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public ClientData()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the identifier.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the client name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the client code.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Code { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we're allowed to edit the item.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanEdit { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we're allowed to delete the item.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean CanDelete { get; set; }
        #endregion
    }
}
