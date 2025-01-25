//-----------------------------------------------------------------------------
// <copyright file="ProjectData.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides project information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ProjectData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public ProjectData()
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
        /// Get or set the project name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the project code.
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
