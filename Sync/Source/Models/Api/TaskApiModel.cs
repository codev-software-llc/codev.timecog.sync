//-----------------------------------------------------------------------------
// <copyright file="TaskApiModel.cs" company="Codev Software, LLC">
// Copyright © 2026
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System.Collections.Generic;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the task as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class TaskApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public TaskApiModel() : base()
        {
            this.Data       = new TaskData();
            this.Allotments = new List<AllotmentApiModel>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the task.
        /// </summary>
        ///--------------------------------------------------------------------
        public TaskData Data { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of allotments for the task.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<AllotmentApiModel> Allotments { get; set; }
        #endregion
    }
}