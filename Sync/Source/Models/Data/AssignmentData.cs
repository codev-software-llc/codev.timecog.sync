//-----------------------------------------------------------------------------
// <copyright file="AssignmentData.cs" company="Codev Software, LLC">
// Copyright © 2024
// </copyright>
//-----------------------------------------------------------------------------
namespace Codev.TimeCog.Sync.Models
{
    using System;
    using Codev.Core.Model;

    ///------------------------------------------------------------------------
    /// <summary>
    /// This provides assignment information.
    /// </summary>
    ///------------------------------------------------------------------------
    public class AssignmentData
    {
        #region Constructors
        ///--------------------------------------------------------------------
        /// <summary>
        /// Instantiate the data object.
        /// </summary>
        ///--------------------------------------------------------------------
        public AssignmentData()
        {
            this.BillingRate = new PaymentAmount();
        }
        #endregion

        #region Properties
        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the assignment identifier as it lives on the server.
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 Id { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the assignment is owned by the account.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsOwner { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the assignment is active.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsActive{ get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the assignment is pending activation.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsPending { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the assignment is expired.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsExpired { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set whether the assignment is a vavorite one.
        /// </summary>
        ///--------------------------------------------------------------------
        public Boolean IsFavorite { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the limitation of time (Hours).
        /// </summary>
        ///--------------------------------------------------------------------
        public Int32 HoursLimit { get; set; }

        ///--------------------------------------------------------------------
        /// <summary>
        /// Get or set the billing rate.
        /// </summary>
        ///--------------------------------------------------------------------
        public PaymentAmount BillingRate { get; set; }

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
