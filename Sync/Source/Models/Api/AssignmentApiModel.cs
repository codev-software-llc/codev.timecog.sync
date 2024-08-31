//-----------------------------------------------------------------------------
// <copyright file="AssignmentApiModel.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    using System.Collections.Generic;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the assignment as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AssignmentApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AssignmentApiModel() : base()
        {
            this.Data  = new AssignmentData();
            this.Tasks = new List<TaskApiModel>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the assignment
        /// </summary>
        ///--------------------------------------------------------------------
        public AssignmentData Data { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of tasks for the assignment.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<TaskApiModel> Tasks { get; set; }
        #endregion
    }
}