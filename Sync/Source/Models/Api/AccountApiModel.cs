//-----------------------------------------------------------------------------
// <copyright file="AccountApiModel.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System.Collections.Generic;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the model for the account as seen through the WebApi.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AccountApiModel : BaseApiModel
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountApiModel() : base()
        {
            this.Data         = new AccountData();
            this.Clients      = new List<ClientApiModel>();
            this.Destinations = new List<DestinationApiModel>();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the data that represents the account.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountData Data { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of clients for the account.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<ClientApiModel> Clients { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the collection of destinations for the account.
        /// </summary>
        ///--------------------------------------------------------------------
        public List<DestinationApiModel> Destinations { get; set; }
        #endregion
    }
}