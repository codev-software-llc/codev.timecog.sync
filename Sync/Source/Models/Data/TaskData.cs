//-----------------------------------------------------------------------------
// <copyright file="TaskData.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides information on the task entity.
    /// </summary>
    ///------------------------------------------------------------------------
    public class TaskData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public TaskData()
        {
            this.Name        = String.Empty;
            this.Description = String.Empty;
            this.Reference   = String.Empty;
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
        /// Get or set the task name.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Name { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the task description.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Description { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the task reference.
        /// </summary>
        ///--------------------------------------------------------------------
        public String Reference { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether this is a default task.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsDefault { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether this is a billable task.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsBillable { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether this is a billable task.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsFavorite { get; set; }

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
