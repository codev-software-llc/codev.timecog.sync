//-----------------------------------------------------------------------------
// <copyright file="AllotmentApiModel.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the allotment as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AllotmentApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AllotmentApiModel() : base()
        {
            this.Data = new AllotmentData();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the allotment.
        /// </summary>
        ///--------------------------------------------------------------------
        public AllotmentData Data { get; set; }
        #endregion
    }
}