//-----------------------------------------------------------------------------
// <copyright file="ProjectApiModel.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System.Collections.Generic;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the project as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ProjectApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public ProjectApiModel() : base()
        {
            this.Data        = new ProjectData();
            this.Assignments = new List<AssignmentApiModel>();
        }
        #endregion

        #region Properties      
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the project.
        /// </summary>
        ///--------------------------------------------------------------------
        public ProjectData Data { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of assignments for the project.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<AssignmentApiModel> Assignments { get; set; }
        #endregion
    }
}