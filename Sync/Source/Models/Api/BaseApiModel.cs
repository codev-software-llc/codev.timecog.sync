//-----------------------------------------------------------------------------
// <copyright file="BaseApiModel.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the base model for a WebApi model.
    /// </summary>
    ///------------------------------------------------------------------------
    public class BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public BaseApiModel()
        {
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we are a new item to be added to the system.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsNew { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we are to delete the item.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsDelete { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether we are modified.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsUpdate { get; set; }
        #endregion
    }
}