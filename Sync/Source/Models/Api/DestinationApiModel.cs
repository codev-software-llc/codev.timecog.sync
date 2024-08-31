//-----------------------------------------------------------------------------
// <copyright file="DestinationApiModel.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the destination (email, phone).
    /// </summary>
    ///------------------------------------------------------------------------
    public class DestinationApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationApiModel() : base()
        {
            this.Data = new DestinationData();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the destination.
        /// </summary>
        ///--------------------------------------------------------------------
        public DestinationData Data { get; set; }
        #endregion
    }
}