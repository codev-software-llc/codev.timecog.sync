//-----------------------------------------------------------------------------
// <copyright file="AllotmentFetchResponse.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the response from an allotment fetch.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AllotmentFetchResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the service.
        /// </summary>
        ///--------------------------------------------------------------------
        public AllotmentFetchResponse()
        {
            this.Allotments = new List<AllotmentApiModel>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the list of allotments.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<AllotmentApiModel> Allotments { get; set; }
        #endregion
    }
}