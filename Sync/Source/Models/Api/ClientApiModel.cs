//-----------------------------------------------------------------------------
// <copyright file="ClientApiModel.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System.Collections.Generic;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the client as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ClientApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public ClientApiModel() : base()
        {
            this.Data     = new ClientData();
            this.Projects = new List<ProjectApiModel>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the client.
        /// </summary>
        ///--------------------------------------------------------------------
        public ClientData Data { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of projects for the client
        /// </summary>
        ///--------------------------------------------------------------------
        public List<ProjectApiModel> Projects { get; set; }
        #endregion
    }
}