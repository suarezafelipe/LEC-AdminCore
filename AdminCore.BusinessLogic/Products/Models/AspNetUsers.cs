using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public int AccessFailedCount { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Id { get; set; }
        public bool? LockoutEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public string UserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ConfirmationToken { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public int? PasswordFailuresSinceLastSuccess { get; set; }
        public DateTime? PasswordChangedDate { get; set; }
        public string PasswordVerificationToken { get; set; }
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; }

        public ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
