//-----------------------------------------------------------------------------
// <copyright file="ConnectResponse.cs" company="Codev Software, LLC">
// Copyright © 2025
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// This is the respons object to connect to the server.
    /// </summary>
    ///------------------------------------------------------------------------
    public class ConnectResponse
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the request.
        /// </summary>
        ///--------------------------------------------------------------------
        public ConnectResponse()
        {
            this.Account = new AccountApiModel();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the account.
        /// </summary>
        ///--------------------------------------------------------------------
        public AccountApiModel Account { get; set; }
        #endregion
    }
}